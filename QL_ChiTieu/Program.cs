using System;
using System.IO;
using System.Windows.Forms;
using Serilog;

namespace QL_ChiTieu
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Thiết lập Serilog ghi file theo ngày vào thư mục Logs cạnh file .exe
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

            Log.Information("Ứng dụng Sổ chi tiêu cá nhân đã khởi động.");

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new FormChiTieu());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Lỗi nghiêm trọng không xác định trong ứng dụng.");
                MessageBox.Show("Đã xảy ra lỗi nghiêm trọng. Thông tin đã được ghi vào nhật ký hệ thống.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("Ứng dụng đã kết thúc.");
                Log.CloseAndFlush();
            }
        }
    }
}