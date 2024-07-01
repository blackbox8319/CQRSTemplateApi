using Application.Common.Interfaces;
using Infrastructure.Common;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Infrastructure.Persistence
{
    public class DbContextService : IDbContextService
    {
        private string ConnectionString() => ConfigurationConstants.DBConnectionString.ToString();
        public SqlConnection CreateDbConnection() => throw new NotImplementedException();

        /******* Use for SQL Server Database connection *******/
        public DbConnection CreateSqlContext() => new SqlConnection(ConnectionString());
        public DbConnection CreateDataBaseContext() => new SqlConnection(ConnectionString());
        /******* Use for Postgres Database connection *******/
        //public DbConnection CreatePostgresContext() => new NpgsqlConnection(ConnectionString());


        /******* Use for MySQL Database connection *******/
        //public DbConnection CreateMySqlContext() => new MySqlConnection(ConnectionString());
    }
}
