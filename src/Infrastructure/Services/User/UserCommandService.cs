using Application.Commands.User;
using Application.Common.Interfaces.User;
using Dapper;
using Domain.Entities;
using Infrastructure.Common.Db;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.User
{
    public class UserCommandService : DbContextService, IUserCommand
    {
    

        public async Task<GenericPair> DeleteUserAsync(DeleteUserCommand deleteUserCommand)
        {
            var dbParams = new DynamicParameters();
            dbParams.Add("LoginId", deleteUserCommand.LoginId, DbType.String, direction: ParameterDirection.Input, size: 64);
            dbParams.Add("ModifiedBy", deleteUserCommand.ModifiedBy, DbType.String, direction: ParameterDirection.Input, size: 64);
            dbParams.Add("@OutMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 128);
            using var con = CreateSqlContext();
            var result = await con.ExecuteAsync(DbStoreProcs.DeleteUserLoginByLoginId, dbParams, commandType: System.Data.CommandType.StoredProcedure);
            con.Close();

            // Retrieve the results from the output parameters
            string outMessage = dbParams.Get<string>("@OutMessage");

            if (outMessage.ToLower().Contains("success"))
                return new GenericPair { Key = true, Value = "Success" };
            else
                return new GenericPair { Key = false, Value = outMessage };
        }

        //public Task<GenericPair> ResetPasswordAsync(ResetPasswordCommand resetPassword)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<GenericPair> UpdateUserAsync(UpdateUserCommand updateUser)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<GenericPair> AddUserAsync(AddUserCommand addUser)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
