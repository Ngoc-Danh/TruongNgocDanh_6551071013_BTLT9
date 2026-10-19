using System;
using System.IO;
using System.Windows.Forms;
using Serilog;

namespace QL_TraSua
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string logsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(logsDir))
            {
                Directory.CreateDirectory(logsDir);
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(
                    path: Path.Combine(logsDir, "log-.txt"),
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();

            Log.Information("Ứng dụng Bán hàng quán trà sữa đã khởi động.");

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new FormBanHang());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Lỗi nghiêm trọng không xác định trong ứng dụng Quán trà sữa.");
                MessageBox.Show("Đã xảy ra lỗi nghiêm trọng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("Ứng dụng Bán hàng quán trà sữa đã kết thúc.");
                Log.CloseAndFlush();
            }
        }
    }
}