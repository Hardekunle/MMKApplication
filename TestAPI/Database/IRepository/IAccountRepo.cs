using TestAPI.Models.DatabaseModels;

namespace TestAPI.Database.IRepository
{
    public interface IAccountRepo
    {
        Task<Account> GetAccountByUsername(string username);
    }
}
