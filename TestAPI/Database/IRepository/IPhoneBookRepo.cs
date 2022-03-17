using TestAPI.Models.DatabaseModels;

namespace TestAPI.Database.IRepository
{
    public interface IPhoneBookRepo
    {
        Task<IEnumerable<PhoneBook>> GetPhonesByAccountId(int accountId);
    }
}
