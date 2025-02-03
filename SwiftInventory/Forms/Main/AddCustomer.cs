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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                passtxt.PasswordChar = '\0';
                confpass.PasswordChar = '\0';
            }
            else
            {
                passtxt.PasswordChar = '*';
                confpass.PasswordChar = '*';
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            new CustomerFrorm().Show();
            this.Hide();
        }

        private void signupname_Click(object sender, EventArgs e)
        {

        }

        private void clearsignup_Click(object sender, EventArgs e)
        {
            signnametxt.Clear();
            emailtxt.Clear();
            passtxt.Clear();
            confpass.Clear();
            addresstxt.Clear();
            phonextxt.Clear();
            companytxt.Clear();
            signnametxt.Focus();
        }

        private void signnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void companytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (signnametxt.Text == "" && emailtxt.Text == "" && passtxt.Text == "" && confpass.Text == "" && addresstxt.Text == "" && phonextxt.Text == "" && companytxt.Text == "" && signnametxt.Text == "")
            {

                MessageBox.Show("fill all the fields");
            }
            else if (passtxt.Text == confpass.Text)
            {

            }
        }
    }
}
