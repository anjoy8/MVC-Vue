using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVC_Vue.Models;
using SqlSugar;

namespace MVC_Vue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            var db = new SqlSugarClient(
             new ConnectionConfig()
             {
                 ConnectionString = "DataSource=" + Path.Combine(Environment.CurrentDirectory, "WMBlog.db"),
                 DbType = DbType.Sqlite,
                 IsAutoCloseConnection = true,
                 InitKeyType = InitKeyType.Attribute
             }
         );

            db.DbMaintenance.CreateDatabase();

            db.CodeFirst.InitTables(typeof(Question));

            host.Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5020")
                .ConfigureLogging((hostingContext, builder) =>
                {
                    builder.ClearProviders();
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    builder.AddConsole();
                    builder.AddDebug();
                });
            });
    }
}
