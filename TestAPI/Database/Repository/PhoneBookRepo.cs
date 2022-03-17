using Dapper;
using Npgsql;
using System.Data;
using TestAPI.Database.IRepository;
using TestAPI.Helpers;
using TestAPI.Models.DatabaseModels;

namespace TestAPI.Database.Repository
{
    public class PhoneBookRepo: IPhoneBookRepo
    {
        private readonly string connectionString;
        internal IDbConnection connection { get { return new NpgsqlConnection(connectionString); } }

        public PhoneBookRepo(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("PostgreSQL");
        }

        public async Task<IEnumerable<PhoneBook>> GetPhonesByAccountId(int accountId)
        {
            var phoneBook = LocalStorage.GetPhoneNumbers();
            var phonelist = phoneBook.Values.Where(x => x.Account_Id.Equals(accountId)).ToList();

            return phonelist;


            //var sqlStatment = "SELECT * FROM <table> WHERE account_Id="+accountId;

            //using (IDbConnection dbConnection = connection)
            //{
            //    dbConnection.Open();
            //    return await dbConnection.QueryAsync<PhoneBook>(sqlStatment);
            //}
        }

    }
}
