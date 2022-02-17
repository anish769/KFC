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
    public partial class StaffUC : UserControl
    {
        public StaffUC()
        {
            InitializeComponent();
        }

        private void StaffUC_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Name is required.");
                return;
            }
            String query = "INSERT INTO Staff (StaffName,Gender,DOB,StaffAddress,Salary) Values('" + txtStaffName.Text + "','" + cmbGender.Text + "','" + txtDOB.Text + "','" + txtStaffAddress.Text + "','" + txtSalary.Text + "')";
            DBConnection.ExecuteNonQuery(query);
            MessageBox.Show("Saved Successfully");
            dataLoad();
            refresh_data();
        }
        public void dataLoad()
        {
            string load = "select*from Staff";
            gvStaff.DataSource = DBConnection.GetTableByQuery(load);

        }

        public void refresh_data()
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtStaffAddress.Text = "";
            txtDOB.Text = "";
            txtSalary.Text = "";
            cmbGender.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want Update",
                   "Important",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            String query = "update  Staff set StaffName=  '" + txtStaffName.Text + "',Gender='" + cmbGender.Text + "',DOB='" + txtDOB.Text + "',StaffAddress='" + txtStaffAddress.Text + "',Salary=  '" + txtSalary.Text + "' where StaffID='" + txtStaffID.Text + "'";
            DBConnection.ExecuteNonQuery(query);
            MessageBox.Show("Update Successfully");
            dataLoad();
            refresh_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want Delete this data",
                "Important",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                String query = "Delete from  Staff where StaffID='" + txtStaffID.Text + "'";
                DBConnection.ExecuteNonQuery(query);
                MessageBox.Show("Deleted Successfully");
                dataLoad();
                refresh_data();
            }
        }

        private void txtSearchStaff_Click(object sender, EventArgs e)
        {
            string search = "select * from Staff where StaffName like '" + txtSearchStaff.Text + "%'";
            gvStaff.DataSource = DBConnection.GetTableByQuery(search);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string StaffID = gvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            string StaffName = gvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Gender= gvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            string DOB= gvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            string StaffAddress = gvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Salary = gvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();


            txtStaffID.Text = StaffID;
            txtStaffName.Text = StaffName;
            cmbGender.Text = Gender;
            txtDOB.Text = DOB;
            txtStaffAddress.Text = StaffAddress;
            txtSalary.Text = Salary;

            
        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string search = "select * from Staff where StaffName like '" + txtSearchStaff.Text + "%'";
            gvStaff.DataSource = DBConnection.GetTableByQuery(search);
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       
 }
 

