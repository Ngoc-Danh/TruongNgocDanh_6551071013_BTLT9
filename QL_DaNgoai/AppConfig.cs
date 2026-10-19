using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QL_DaNgoai.Models;

namespace QL_DaNgoai
{
    public class AppSettings
    {
        public ConnectionStringsSettings ConnectionStrings { get; set; } = new();
    }

    public class ConnectionStringsSettings
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public static class AppConfig
    {
        public static AppSettings Settings { get; private set; } = new();

        static AppConfig()
        {
            var env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true);

            var config = builder.Build();
            Settings = config.Get<AppSettings>() ?? new AppSettings();
        }

        public static QL_DaNgoaiContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<QL_DaNgoaiContext>();
            optionsBuilder.UseSqlServer(Settings.ConnectionStrings.DefaultConnection);
            return new QL_DaNgoaiContext(optionsBuilder.Options);
        }
    }
}
