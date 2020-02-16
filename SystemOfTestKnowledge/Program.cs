using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MyWebTest.Models;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace MyWebTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();

            CultureInfo.CurrentCulture = new CultureInfo("en", true);
            CultureInfo.CurrentUICulture = new CultureInfo("en", true);
            var host = CreateWebHostBuilder(args).ConfigureLogging((context, logging) =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddConfiguration(context.Configuration.GetSection("Logging"));
            })
            .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SystemContext>();
                    SampleData.Initialize(context);
                    if (!context.Comments.Any())
                    {
                        context.Comments.AddRange
                            (
                                new Comment
                                {
                                    Text = "Hello, World :)",
                                    UserName = "User"
                                }
                                );
                        context.SaveChanges();
                    }
                    var userManager = services.GetRequiredService<UserManager<User>>();
                    var rolesManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var t = RoleInitializer.InitializeAsync(userManager, rolesManager);
                    t.Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
