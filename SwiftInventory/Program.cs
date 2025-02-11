using SwiftInventory.Common;
using SwiftInventory.Forms.Auth;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormManager.AuthFormInstance = new AuthForm();
            Application.Run(FormManager.AuthFormInstance);
        }
    }
}
