using System.Data.Common;
using System.Data.SqlClient;

namespace Application.Common.Interfaces
{
    public interface IDbContextService
    {
        /** He we can return type of connection
         * this will follow the desire Db connection
         * we wish to establish */
        SqlConnection CreateDbConnection();
        DbConnection CreateSqlContext();
        //DbConnection CreatePostgresContext();
        //DbConnection CreateMySqlContext();

    }
}
