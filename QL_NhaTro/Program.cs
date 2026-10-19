using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Serilog;

namespace QL_NhaTro
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Thiết lập Serilog
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

            Log.Information("Ứng dụng Quản lý nhà trọ đã khởi động.");

            // Đăng ký xử lý lỗi toàn cục
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Xử lý lỗi UI Thread
            Application.ThreadException += new ThreadExceptionEventHandler((sender, e) =>
            {
                Log.Error(e.Exception, "Lỗi UI Thread chưa được bắt (Application.ThreadException)");
                MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });

            // Xử lý lỗi Non-UI Thread / AppDomain
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    Log.Error(ex, "Lỗi AppDomain chưa được bắt (AppDomain.CurrentDomain.UnhandledException)");
                }
                MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new FormKhachThue());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Lỗi nghiêm trọng cấp cao nhất trong ứng dụng.");
                MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("Ứng dụng Quản lý nhà trọ đã kết thúc.");
                Log.CloseAndFlush();
            }
        }
    }
}