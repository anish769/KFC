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
namespace KFC
{
    public partial class NewPass : MaterialSkin.Controls.MaterialForm
    {
        string username = ForgetPassword.to;
        public NewPass()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void NewPass_Load(object sender, EventArgs e)
        {

            txtNewPass.Text = "Enter new password";
            txtVerifyPass.Text = "Re-enter new password";
        }

       

        private void TxtNewPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtVerifyPass_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void TxtNewPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Enter new password")
            {
                txtNewPass.Text = "";
            }
        }

        private void TxtNewPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Enter new password";
            }
        }

        private void TxtVerifyPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtVerifyPass.Text == "Re-enter new password")
            {
                txtVerifyPass.Text = "";
            }
        }

        private void TxtVerifyPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtVerifyPass.Text == "")
            {
                txtVerifyPass.Text = "Re-enter new password";
            }
        }

        private void BtnConfirm_Click_2(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtVerifyPass.Text)
            {
                SqlConnection con = new SqlConnection(" Data Source =.; Initial Catalog = KFC; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[login] SET [Password] ='" + txtVerifyPass.Text + "' WHERE Username='" + username + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed Successfully");

                LoginForm LF = new LoginForm();
                this.Hide();
                LF.Show();
            }
        }

        private void TxtNewPass_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtVerifyPass.Text)
            {
                SqlConnection con = new SqlConnection(" Data Source =.; Initial Catalog = KFC; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[login] SET [Password] ='" + txtVerifyPass.Text + "' WHERE Username='" + username + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed Successfully");

                LoginForm LF = new LoginForm();
                this.Hide();
                LF.Show();
            }
        }
    }
   
}
