using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RunMun
{
    public class ConfrenceConfiguration
    {
        public static IConfiguration Configuration;

        public static void LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("config.json");
            Configuration = builder.Build();
        }

    }

}
