using System.Windows.Forms;

namespace SwiftInventory.Forms.Common
{
    public partial class BaseForm : Form
    {
        private Form _activeForm = null;

        public BaseForm()
        {
            InitializeComponent();
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
    }
}
