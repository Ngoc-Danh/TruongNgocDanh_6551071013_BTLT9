using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QL_TraSua.Models;

namespace QL_TraSua
{
    public class ConnectionStringsSettings
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public class PaymentSettings
    {
        public string BankId { get; set; } = "970436";
        public string AccountNo { get; set; } = "1234567890";
        public string AccountName { get; set; } = "QUAN TRA SUA";
        public string Template { get; set; } = "compact2";
        public string TenQuan { get; set; } = "TRÀ SỮA COZY";
        public string TenNganHang { get; set; } = "VIETCOMBANK";
    }

    public class AppSettings
    {
        public ConnectionStringsSettings ConnectionStrings { get; set; } = new();
        public PaymentSettings Payment { get; set; } = new();
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

        public static QL_TraSuaContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<QL_TraSuaContext>();
            optionsBuilder.UseSqlServer(Settings.ConnectionStrings.DefaultConnection);
            return new QL_TraSuaContext(optionsBuilder.Options);
        }
    }
}
