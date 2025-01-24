using SwiftInventory.Database;
using SwiftInventory.Forms.Main;
using System;
using System.Windows.Forms;

namespace SwiftInventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var executablePath = AppDomain.CurrentDomain.BaseDirectory;
            //var projectPath = Directory.GetParent(executablePath)?.Parent?.Parent?.Parent?.FullName;

            //if (projectPath != null)
            //{
            //    AppDomain.CurrentDomain.SetData("DataDirectory", projectPath);
            //}

            bool connected = DatabaseConfig.IsConnected();

            MessageBox.Show(connected ? "Connected" : "Not connected");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminForm());
        }
    }
}
