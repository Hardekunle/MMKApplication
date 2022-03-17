namespace TestAPI.Services
{
    public interface ICacheService
    {
        Task<T> GetCacheValueAsync<T>(string key);
        Task SetCacheValueAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime=null, TimeSpan? UnusedExpiryTime=null);
    }
}
