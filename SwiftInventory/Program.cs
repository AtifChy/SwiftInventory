using SwiftInventory.Common;
using SwiftInventory.Database;
using SwiftInventory.Forms.Auth;
using System;
using System.Windows.Forms;

namespace SwiftInventory
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(int awareness);

        const int PROCESS_PER_MONITOR_DPI_AWARE = 2;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Test code to check if the database is connected
            // var connected = DatabaseConfig.IsConnected();
            // MessageBox.Show(connected ? "Connected" : "Not connected");
            UserSession.UserId = 1;
            var user = UserQueries.GetUser(UserSession.UserId);
            UserSession.Role = user["Role"].ToString();
            UserSession.UserName = user["UserName"].ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
