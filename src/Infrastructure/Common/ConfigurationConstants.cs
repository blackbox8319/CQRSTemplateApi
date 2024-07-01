using Microsoft.Extensions.Configuration;
using System.IO;

namespace Infrastructure.Common
{
    internal static class ConfigurationConstants
    {
        public readonly static object DBConnectionString = ("DBConnectionString").AppSettings();

        public static object AppSettings(this string key, string path = "db")
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            return path switch
            {
                "db" => config["ConnectionStrings:" + key],
                _ => config[key],
            };
        }
    }


}
