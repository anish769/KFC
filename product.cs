using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class product : Form
    {
       

        public product()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void Loader_Tick(object sender, EventArgs e)
        {
            //if (loder.Value <100)
            //{
              //  loder.Value++;
               
            //}
            //else
            //{
             //   panel1.Visible = false;
           // }
        }
       
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Delays_Tick(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }








    
}
