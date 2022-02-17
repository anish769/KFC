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
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            this.Hide();
            fp.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Username";
            txtPassword.Text = "Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

      

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
                
            }

     

        

        
        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void TxtPassword_MouseLeave_1(object sender, EventArgs e)
        {

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void TxtUser_MouseLeave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
            }
        }


        private void TxtUser_MouseEnter(object sender, EventArgs e)
        {

            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
            }
        }

        private void TxtUser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANISH;Initial Catalog=SMS;Integrated Security=True";
            con.Open();
            string userid = txtUser.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("Select Username,Password from login where Username='" + txtUser.Text + "'and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
                dashboard db = new dashboard();
                this.Hide();
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
