using Dapper;
using Npgsql;
using System.Data;
using TestAPI.Database.IRepository;
using TestAPI.Models.DatabaseModels;

namespace TestAPI.Database.Repository
{
    public class AccountRepo : IAccountRepo
    {
        private readonly string connectionString;
        internal IDbConnection connection { get { return new NpgsqlConnection(connectionString); } }
        public AccountRepo(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("PostgreSQL");
        }

        public async Task<Account> GetAccountByUsername(string username)
        {
            return new Account { Id = 23, Auth_Id = "Adekunle1", Username = "Adekunle" };
            var sqlStatement = "";
            using (IDbConnection dbConnection = connection)
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<Account>(sqlStatement);
            }
        }
    }
}
