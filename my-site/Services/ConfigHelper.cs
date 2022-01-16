using System;
using Microsoft.Extensions.Configuration;

namespace my_site.Services
{
    public class ConfigHelper 
    {
        public IConfiguration configuration { get; }

        public ConfigHelper()
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
