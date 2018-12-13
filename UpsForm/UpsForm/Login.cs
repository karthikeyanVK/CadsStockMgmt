using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ElectronicShop.PresentationLayer
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="Nivedha" && txtPassword.Text=="Nivedha")
            {
                Menu form3 = new Menu("Welcome " + txtUsername.Text);
                form3.ShowDialog();               
            }
            else if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show(Filepath.BothField);
            }
            else if(txtUsername.Text == "" && txtPassword.Text == "Nivedha")
            {
                MessageBox.Show(Filepath.UserField);
            }
            else if (txtUsername.Text == "Nivedha" && txtPassword.Text == "")
            {
                MessageBox.Show(Filepath.PasswordField);

            }
            else
            {
                MessageBox.Show(Filepath.BothInvalid);
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text, "[^A-Z,a-z]"))
            {
                MessageBox.Show(Filepath.OnlyAlphabets);
                txtUsername.Text = txtUsername.Text.Remove(txtUsername.Text.Length - 1);
            }
        }
    }
}
