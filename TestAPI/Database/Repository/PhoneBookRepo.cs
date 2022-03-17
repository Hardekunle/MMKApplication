using Dapper;
using Npgsql;
using System.Data;
using TestAPI.Database.IRepository;
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
            var sqlStatment = "SELECT * FROM <> WHERE account_Id="+accountId;

            using (IDbConnection dbConnection = connection)
            {
                dbConnection.Open();
                return await dbConnection.QueryAsync<PhoneBook>(sqlStatment);
            }
        }

    }
}
