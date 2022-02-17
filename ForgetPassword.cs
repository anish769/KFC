using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace KFC
{
    public partial class ForgetPassword : MaterialSkin.Controls.MaterialForm
    {
        string randomCode;
        public static string to;
        public ForgetPassword()
        {

            InitializeComponent();
            
           
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void txtContinue_Click(object sender, EventArgs e)
        {
           
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        } 

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnSendCode_Click_1(object sender, EventArgs e)
        {
            



        }

        private void txtVerifyCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            



          




        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtSendCode_Click(object sender, EventArgs e)
        {
           

        }

        private void TxtVerifyCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click_1(object sender, EventArgs e)
        {
            if (randomCode == (txtVerifyCode.Text).ToString())
            {
                to = txtEmail.Text;
                NewPass np = new NewPass();
                this.Hide();
                np.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void BtnSendCode_Click(object sender, EventArgs e)
        {
            string from, pass, MessageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "atboy769@gmail.com";
            pass = "atboyatboy769";
            MessageBody = "Your reset code is" + " " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = MessageBody;
            message.Subject = "KFC Password Reset";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            panel2.Visible = true;



            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send Successfully");
                panel1.Visible = false;
                panel2.Visible = true;


            }
            catch (Exception)
            {
                MessageBox.Show("Please check your internet connection");
            }
        }

        private void TxtEmail_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TxtEmail_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
    
}
