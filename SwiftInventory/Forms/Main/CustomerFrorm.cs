using SwiftInventory.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInventory
{
    public partial class CustomerFrorm : Form
    {
        public CustomerFrorm()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            new CustomerEditForm().Show();
            this.Hide();
        }

        private void View_Click(object sender, EventArgs e)
        {

        }

        private void CustomerFrorm_Load(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
