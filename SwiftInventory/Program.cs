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
            // Test code to check if the database is connected
            // var connected = DatabaseConfig.IsConnected();
            // MessageBox.Show(connected ? "Connected" : "Not connected");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SalesAndOrdersForm());
        }
    }
}
