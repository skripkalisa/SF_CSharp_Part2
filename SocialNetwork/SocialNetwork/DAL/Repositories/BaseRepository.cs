using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.DAL.Repositories
{
    public class BaseRepository
    {
        
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {
            using var connection = CreateConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<T>(sql, parameters);
        }

        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using var connection = CreateConnection();
            connection.Open();
            return connection.Query<T>(sql, parameters).ToList();
        }

        protected int Execute(string sql, object parameters = null)
        {
            using var connection = CreateConnection();
            connection.Open();
            return connection.Execute(sql, parameters);
        }

        private IDbConnection CreateConnection()
        {
            var ap = new AbsolutePath();

            return new SQLiteConnection($"Data Source = {ap.GetProjectDirectory()}/DAL/DB/social_network.db; Version = 3");
        }
    }
}
