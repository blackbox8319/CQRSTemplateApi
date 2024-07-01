using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Common.Interfaces.User;
using Application.Queries.User;
using Dapper;
using Domain.Entities.User;
using Infrastructure.Common.Db;
using Infrastructure.Persistence;

namespace Infrastructure.Services.User
{
    public class UserQueryService : DbContextService, IUserQuery
    {
        public async Task<UserAuth> FindUserByIdAsync(string userName)
        {
            var dbParams = new DynamicParameters();
            dbParams.Add("UserName", userName);
            using var con = CreateSqlContext();
            var result = await con.QueryAsync<UserAuth>(DbStoreProcs.UserByName, dbParams, commandType: System.Data.CommandType.StoredProcedure);
            con.Close();
            return result.FirstOrDefault();
        }

        //public async Task<IList<Users>> FetchUserAsync(string role)
        //{
        //    var dbParams = new DynamicParameters();
        //    dbParams.Add("Role", role != "null" && role != null ? role : "");
        //    using var con = CreateMySqlContext();
        //    var result = await con.QueryAsync<Users>(DbStoreProcs.FetchUsers, dbParams, commandType: CommandType.StoredProcedure);
        //    con.Close();
        //    return result.ToList();
        //}

        //public async Task<Users> UserByNameAsync(string userName)
        //{
        //    var dbParams = new DynamicParameters();
        //    dbParams.Add("UserName", userName);
        //    using var con = CreateMySqlContext();
        //    var result = await con.QueryAsync<Users>(DbStoreProcs.UserByName, dbParams, commandType: System.Data.CommandType.StoredProcedure);
        //    con.Close();
        //    return result.FirstOrDefault();
        //}

        
    }
}
