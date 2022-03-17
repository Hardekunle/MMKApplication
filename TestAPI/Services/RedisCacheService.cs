using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace TestAPI.Services
{
    public class RedisCacheService : ICacheService
    {
        private readonly IDistributedCache _cache;
        private readonly IMemoryCache _memoryCache;
        public RedisCacheService(IDistributedCache cache, IMemoryCache memoryCache)
        {
            _cache = cache;
            _memoryCache = memoryCache;
        }
        public async Task<T> GetCacheValueAsync<T>(string key)
        {
            //use after connecting to redis
            //var data= await _cache.GetStringAsync(key);

            //if (data == null) return default(T);
            //return JsonConvert.DeserializeObject<T>(data);

            string data = null;
            if(!_memoryCache.TryGetValue(key, out data)) return default(T);
            return JsonConvert.DeserializeObject<T>(data);

        }

        public async Task SetCacheValueAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime, TimeSpan? UnusedExpiryTime)
        {
            //uncomment after connecting to redis
            //var options = new DistributedCacheEntryOptions();
            
            //options.AbsoluteExpirationRelativeToNow = absoluteExpiryTime ?? TimeSpan.FromMinutes(1560);
            var serializedData = JsonConvert.SerializeObject(data);

            //await _cache.SetStringAsync(key, serializedData, options);

             var cacheOptions = new MemoryCacheEntryOptions()
                                        .SetAbsoluteExpiration(absoluteExpiryTime ?? TimeSpan.FromMinutes(1560));

            _memoryCache.Set(key,serializedData, cacheOptions);
        }
    }
}
