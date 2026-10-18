using AppDeployment_Chap11.Helpers;
using Serilog;

namespace AppDeployment_Chap11
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                AppConfig.Initialize();

                LogHelper.Initialize();

                string culture = UserSettings.Load().Culture ?? AppConfig.Settings.DefaultCulture;
                Strings.SetCulture(culture);

                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += (s, e) =>
                {
                    Log.Error(e.Exception, "Lỗi UI Thread không được xử lý");
                    MessageBox.Show(Strings.Get("LoiChung"), "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                {
                    Log.Fatal(e.ExceptionObject as Exception, "Lỗi nghiêm trọng toàn hệ thống — app sắp đóng");
                    MessageBox.Show(Strings.Get("LoiChung"), "Lỗi nghiêm trọng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                };

                ApplicationConfiguration.Initialize();
                Application.Run(new FormMain());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Không thể khởi động ứng dụng");
                MessageBox.Show("Không thể khởi động ứng dụng:\n\n" + ex.Message,
                    "Lỗi khởi động", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LogHelper.Shutdown();
            }
        }
    }
}