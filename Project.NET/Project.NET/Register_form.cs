using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtRegpass.PasswordChar == '*')
            {
                peye.BringToFront();
                txtRegpass.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtRegpass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtRegpass.PasswordChar = '*';
            }
        }

        private void peye1_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '\0')
            {
                phide1.BringToFront();
                txtConfirmpass.PasswordChar = '*';
            }
        }

        private void phide1_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '*')
            {
                peye1.BringToFront();
                txtConfirmpass.PasswordChar = '\0';
            }
        }

        private void Register_form_Load(object sender, EventArgs e)
        {

        }
    }
}
