using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Helper
{
    public class ConfigManager
    {
        private readonly IConfiguration _configuration;
        public ConfigManager(IConfiguration IConfiguration)
        {
            _configuration = IConfiguration;
            UserName = GetKey<string>("AuthSettings:UserName");
            Password = GetKey<string>("AuthSettings:Password");
            ClientCode = GetKey<string>("AuthSettings:ClientCode");

        }

        public string UserName { get; }
        public string Password { get; }
        public string ClientCode { get; }

        private T GetKey<T>(string key, bool required = false)
        {
            var value = _configuration[key];

            if (required && string.IsNullOrWhiteSpace(value))
            {
                throw new Exception($"Configuration key '{key}' is missing or empty.");
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}