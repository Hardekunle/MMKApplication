using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace TestAPI.Services
{
    public class RedisCacheService : ICacheService
    {
        private readonly IDistributedCache _cache;
        public RedisCacheService(IDistributedCache cache)
        {
            _cache = cache;
        }
        public async Task<T> GetCacheValueAsync<T>(string key)
        {
            var data= await _cache.GetStringAsync(key);

            if(data==null) return default(T);
            return JsonConvert.DeserializeObject<T>(data);

        }

        public async Task SetCacheValueAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime, TimeSpan? UnusedExpiryTime)
        {
            var options = new DistributedCacheEntryOptions();
            
            options.AbsoluteExpirationRelativeToNow = absoluteExpiryTime ?? TimeSpan.FromMinutes(1560);
            var serializedData = JsonConvert.SerializeObject(data);

            await _cache.SetStringAsync(key, serializedData, options);
        }
    }
}
