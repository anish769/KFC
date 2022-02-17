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
    public partial class dashboard : MaterialSkin.Controls.MaterialForm
    {
        public dashboard()
        {
            InitializeComponent();
            SidePanel.Height = bHome.Height;
            SidePanel.Top = bHome.Top;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        
      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void bHome_Click(object sender, EventArgs e)
        {
            
        }

        private void bFood_Click(object sender, EventArgs e)
        {
        }

        private void bHome_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = bHome.Height;
            SidePanel.Top = bHome.Top;
        }

        private void bFood_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = bFood.Height;
            SidePanel.Top = bFood.Top;
        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kFCDataSet.Customer' table. You can move, or remove it, as needed.
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userControlCus1_Load(object sender, EventArgs e)
        {

        }

        private void userControlCus1_Load_1(object sender, EventArgs e)
        {

        }
    }

}





      