using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using System.Configuration;

namespace ConfigurationTest
{
    class AppSettingsConfigurationProvider : ConfigurationProvider
    {
        public override void Load()
        {
            var appSettings = ConfigurationManager.AppSettings;

            var settings = new Dictionary<string, string>();
            foreach(var key in ConfigurationManager.AppSettings.AllKeys)
            {
                settings[key] = appSettings[key];
            }
            
            Data = settings;
        }
    }
}
