using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Utils
{
    internal class ConfigHelper
    {
        public static DBSettings LoadDBSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();
            var settings = config.Get<DBSettings>();
            return settings;
        }

        public static string GetConnectionString()
        {
            var s = LoadDBSettings();
            return $"Host={s.Host};Port={s.Port};Database={s.Database};Username={s.Username};Password={s.Password}";
        }
    }
}
