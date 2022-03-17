using TestAPI.Database.IRepository;
using TestAPI.Helpers;
using TestAPI.Models.ClientModels;
using TestAPI.Models.DatabaseModels;

namespace TestAPI.Services
{
    public class MessageService : IMessageService
    {
        private readonly IPhoneBookRepo _phoneBookDB;
        private readonly IAccountRepo _accountRepo;
        private readonly ICacheService _cache;
        private const int phoneCacheExpiryTime = 240;//in minutes
        private const int requestLimitVal = 50;
        private const int requestLimitPeriod = 1440; //in minutes

        public MessageService(IPhoneBookRepo phoneBookDB, ICacheService cacheService, IAccountRepo accountRepo)
        {
            _phoneBookDB = phoneBookDB;
            _cache = cacheService;
            _accountRepo = accountRepo;
        }
        public async Task<bool> InBoundRequest(int loggedInUserId, SMSDTO request)
        {
            await ValidatePhoneRecord(loggedInUserId, request.From);

            if (request.Text.CheckMatchingRule("STOP"))
            {
                string cacheKey = Generators.GeneratePhoneCacheKey(request.From, request.To);
                await _cache.SetCacheValueAsync(cacheKey, request, new TimeSpan(0,phoneCacheExpiryTime,0));
            }

            return true;

        }

        public async Task<bool> OutBoundRequest(int loggedInUserId, SMSDTO request)
        {
            var trackerKey = Generators.GenerateTrackerKey(request.From);
            var messageKey = Generators.GeneratePhoneCacheKey(request.From, request.To);

            await ValidatePhoneRecord(loggedInUserId, request.From, KeyActor.from);
            await ValidateCachedData(messageKey);
            await ValidateRequestCount(request, trackerKey);

            return true;

        }

        private async Task ValidatePhoneRecord(int loggedInUserId, string fromPerson, KeyActor actor= KeyActor.to)
        {
            IEnumerable<PhoneBook> loggedUserPhones = await _phoneBookDB.GetPhonesByAccountId(loggedInUserId);
            if (!loggedUserPhones.Any(x => x.Number.Equals(fromPerson)))
                throw new Exception(actor + " parameter not found");
        }

        private async Task ValidateCachedData(string messageKey)
        {
            var data = await _cache.GetCacheValueAsync<SMSDTO>(messageKey);
            if (data != null) throw new Exception("sms from "+data.From+" to "+data.To+" blocked by STOP request");
        }

        private async Task ValidateRequestCount(SMSDTO request, string trackerKey)
        {
            int previousCount = 0;
            //check if 24 hours tracker is active
            bool trackerExist = await _cache.GetCacheValueAsync<bool>(trackerKey);
            if (!trackerExist)
            {
                //set it to active
                await _cache.SetCacheValueAsync(trackerKey, true, new TimeSpan(0,requestLimitPeriod,0));
            }
            else //this means the 24hrs tracker is already active
            {
                //get the request count: if no similar request has been made it returns 0
                previousCount = await _cache.GetCacheValueAsync<int>(request.From);
                //if 50 request has been made, throw an error
                if (previousCount == requestLimitVal) throw new Exception("Limit reached for from "+ request.From);
            }

            int requestCount = previousCount + 1;
            await _cache.SetCacheValueAsync<int>(request.From, requestCount);
        }
    }
}
