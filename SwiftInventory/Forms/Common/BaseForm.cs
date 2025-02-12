using Microsoft.Win32;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Common
{
    public partial class BaseForm : Form
    {
        [DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private Form _activeForm;

        public BaseForm()
        {
            InitializeComponent();
            UpdateTheme();
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                string projectName = GetProjectName();
                base.Text = !value.EndsWith($@" - {projectName}") ? $@"{value} - {projectName}" : value;
            }
        }

        private static string GetProjectName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        protected void OpenChildForm(Panel panelContainer, Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void UpdateTheme()
        {
            int darkMode = IsWindowsDarkModeEnabled() ? 1 : 0;
            DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));
        }

        private bool IsWindowsDarkModeEnabled()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    return key?.GetValue("AppsUseLightTheme") is int value && value == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                UpdateTheme();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= SystemEvents_UserPreferenceChanged;
            base.OnFormClosing(e);
        }
    }
}
