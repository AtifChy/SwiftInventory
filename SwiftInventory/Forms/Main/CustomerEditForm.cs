using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class CustomerEditForm : Form
    {
        public CustomerEditForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new CustomerFrorm().Show();
            this.Hide();
        }
    }
}
