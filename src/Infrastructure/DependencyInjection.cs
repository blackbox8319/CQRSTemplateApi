using Application.Common.Interfaces;
using Application.Common.Interfaces.User;
using Dapper;
using Infrastructure.Common.TypeHandlers;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Infrastructure.Services.User;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IDbContextService, DbContextService>();
            SqlMapper.AddTypeHandler(new SqlGuidTypeHandler());
            SqlMapper.RemoveTypeMap(typeof(Guid));
            SqlMapper.RemoveTypeMap(typeof(Guid?));
            services.AddTransient<IUserQuery, UserQueryService>();
            services.AddTransient<IUserCommand, UserCommandService>();
            return services;
        }
    }

}
