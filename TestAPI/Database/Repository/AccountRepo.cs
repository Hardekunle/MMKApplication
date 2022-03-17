﻿using Dapper;
using Npgsql;
using System.Data;
using TestAPI.Database.IRepository;
using TestAPI.Helpers;
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
            var localAccountStore = LocalStorage.GetAccounts();
            var normalizedname = username.ToLower();

            var isValid = localAccountStore.ContainsKey(normalizedname);
            if (!isValid)
                return null;

            var response = localAccountStore[normalizedname];
            return response;

            //am having issues hosting on heroku, so i decided to use local storage
            //var sqlStatement = "SELECT * FROM <table> WHERE Username="+normalizedName;
            //using (IDbConnection dbConnection = connection)
            //{
            //    dbConnection.Open();
            //    return await dbConnection.QueryFirstOrDefaultAsync<Account>(sqlStatement);
            //}
        }
    }
}
