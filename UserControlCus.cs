using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KFC
{
    public partial class UserControlCus : UserControl
    {
        public UserControlCus()
        {
            InitializeComponent();
            dataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Name is required.");
                return;
            }
            String query = "INSERT INTO Customer (CustomerName,CustomerAddress,ContactNumber,Email) Values('" + txtCustomerName.Text + "','" + txtCustomerAddress.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "')";
            DBConnection.ExecuteNonQuery(query);
            MessageBox.Show("Saved Successfully");
            dataLoad();
            refresh_data();
        }
        public void dataLoad()
        {
            string load = "select*from Customer";
            gvCustomer.DataSource = DBConnection.GetTableByQuery(load);

        }

        public void refresh_data()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlCus_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you Want Update",
                    "Important",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            String query = "update  Customer set CustomerName=  '" + txtCustomerName.Text + "',CustomerAddress='" + txtCustomerAddress.Text + "',ContactNumber='" + txtContact.Text + "',Email='" + txtEmail.Text + "' where CustomerID='" + txtCustomerID.Text + "'";
            DBConnection.ExecuteNonQuery(query);
            MessageBox.Show("Update Successfully");
            dataLoad();
            refresh_data();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            string search = "select * from Customer where CustomerName like '" + txtSearchCustomer.Text + "%'";
            gvCustomer.DataSource = DBConnection.GetTableByQuery(search);
        }

        private void gvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cid = gvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            string cname = gvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            string caddress = gvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            string ccontact = gvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            string cemail = gvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtCustomerID.Text = cid;
            txtCustomerName.Text = cname;
            txtCustomerAddress.Text = caddress;
            txtContact.Text = ccontact;
            txtEmail.Text = cemail;

            btnSave.Enabled = false;

        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string search = "select * from Customer where CustomerName like '" + txtSearchCustomer.Text + "%'";
            gvCustomer.DataSource = DBConnection.GetTableByQuery(search);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want Delete this data",
                "Important",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                String query = "Delete from  Customer where CustomerID='" + txtCustomerID.Text + "'";
                DBConnection.ExecuteNonQuery(query);
                MessageBox.Show("Deleted Successfully");
                dataLoad();
                refresh_data();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_Click(object sender, EventArgs e)
        {

        }
    }
}
