namespace KFC
{
    partial class StaffUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchStaff = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOB = new MetroFramework.Controls.MetroDateTime();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStaffAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtStaffID = new MetroFramework.Controls.MetroTextBox();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.gvStaff = new MetroFramework.Controls.MetroGrid();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kFCDataSet1 = new KFC.KFCDataSet1();
            this.staffTableAdapter = new KFC.KFCDataSet1TableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(189, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 103);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 420);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 420);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(289, 398);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 103);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(20, 398);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(261, 103);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchStaff
            // 
            // 
            // 
            // 
            this.txtSearchStaff.CustomButton.Image = null;
            this.txtSearchStaff.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtSearchStaff.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStaff.CustomButton.Name = "";
            this.txtSearchStaff.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearchStaff.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchStaff.CustomButton.TabIndex = 1;
            this.txtSearchStaff.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchStaff.CustomButton.UseSelectable = true;
            this.txtSearchStaff.CustomButton.Visible = false;
            this.txtSearchStaff.Lines = new string[0];
            this.txtSearchStaff.Location = new System.Drawing.Point(184, 30);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStaff.MaxLength = 32767;
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.PasswordChar = '\0';
            this.txtSearchStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchStaff.SelectedText = "";
            this.txtSearchStaff.SelectionLength = 0;
            this.txtSearchStaff.SelectionStart = 0;
            this.txtSearchStaff.ShortcutsEnabled = true;
            this.txtSearchStaff.Size = new System.Drawing.Size(209, 29);
            this.txtSearchStaff.TabIndex = 3;
            this.txtSearchStaff.UseSelectable = true;
            this.txtSearchStaff.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchStaff.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchStaff.TextChanged += new System.EventHandler(this.txtSearchStaff_TextChanged);
            this.txtSearchStaff.Click += new System.EventHandler(this.txtSearchStaff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Staff Address";
            // 
            // txtStaffName
            // 
            // 
            // 
            // 
            this.txtStaffName.CustomButton.Image = null;
            this.txtStaffName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtStaffName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.CustomButton.Name = "";
            this.txtStaffName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStaffName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffName.CustomButton.TabIndex = 1;
            this.txtStaffName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffName.CustomButton.UseSelectable = true;
            this.txtStaffName.CustomButton.Visible = false;
            this.txtStaffName.Lines = new string[0];
            this.txtStaffName.Location = new System.Drawing.Point(189, 74);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.MaxLength = 32767;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.PasswordChar = '\0';
            this.txtStaffName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffName.SelectedText = "";
            this.txtStaffName.SelectionLength = 0;
            this.txtStaffName.SelectionStart = 0;
            this.txtStaffName.ShortcutsEnabled = true;
            this.txtStaffName.Size = new System.Drawing.Size(261, 31);
            this.txtStaffName.TabIndex = 6;
            this.txtStaffName.UseSelectable = true;
            this.txtStaffName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Staff Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Search Staff";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.txtSalary);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.txtDOB);
            this.metroPanel1.Controls.Add(this.cmbGender);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.txtStaffName);
            this.metroPanel1.Controls.Add(this.txtStaffAddress);
            this.metroPanel1.Controls.Add(this.txtStaffID);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.129032F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 14;
            this.metroPanel1.Location = new System.Drawing.Point(28, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(503, 554);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtSalary.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(189, 300);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(261, 31);
            this.txtSalary.TabIndex = 23;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Salary";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(189, 187);
            this.txtDOB.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(261, 29);
            this.txtDOB.TabIndex = 21;
            this.txtDOB.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.AccessibleName = "";
            this.cmbGender.CausesValidation = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(189, 131);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(261, 29);
            this.cmbGender.TabIndex = 21;
            this.cmbGender.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 410);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtStaffAddress
            // 
            // 
            // 
            // 
            this.txtStaffAddress.CustomButton.Image = null;
            this.txtStaffAddress.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtStaffAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffAddress.CustomButton.Name = "";
            this.txtStaffAddress.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStaffAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffAddress.CustomButton.TabIndex = 1;
            this.txtStaffAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffAddress.CustomButton.UseSelectable = true;
            this.txtStaffAddress.CustomButton.Visible = false;
            this.txtStaffAddress.Lines = new string[0];
            this.txtStaffAddress.Location = new System.Drawing.Point(189, 243);
            this.txtStaffAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffAddress.MaxLength = 32767;
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.PasswordChar = '\0';
            this.txtStaffAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffAddress.SelectedText = "";
            this.txtStaffAddress.SelectionLength = 0;
            this.txtStaffAddress.SelectionStart = 0;
            this.txtStaffAddress.ShortcutsEnabled = true;
            this.txtStaffAddress.Size = new System.Drawing.Size(261, 31);
            this.txtStaffAddress.TabIndex = 3;
            this.txtStaffAddress.UseSelectable = true;
            this.txtStaffAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStaffID
            // 
            // 
            // 
            // 
            this.txtStaffID.CustomButton.Image = null;
            this.txtStaffID.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtStaffID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffID.CustomButton.Name = "";
            this.txtStaffID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffID.CustomButton.TabIndex = 1;
            this.txtStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffID.CustomButton.UseSelectable = true;
            this.txtStaffID.CustomButton.Visible = false;
            this.txtStaffID.Lines = new string[0];
            this.txtStaffID.Location = new System.Drawing.Point(189, 30);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffID.MaxLength = 32767;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PasswordChar = '\0';
            this.txtStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffID.SelectedText = "";
            this.txtStaffID.SelectionLength = 0;
            this.txtStaffID.SelectionStart = 0;
            this.txtStaffID.ShortcutsEnabled = true;
            this.txtStaffID.Size = new System.Drawing.Size(261, 35);
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.UseSelectable = true;
            this.txtStaffID.Visible = false;
            this.txtStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.93548F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Details";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.gvStaff);
            this.metroPanel2.Controls.Add(this.pictureBox3);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnEdit);
            this.metroPanel2.Controls.Add(this.txtSearchStaff);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 14;
            this.metroPanel2.Location = new System.Drawing.Point(539, 60);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(644, 554);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 12;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // gvStaff
            // 
            this.gvStaff.AllowUserToResizeRows = false;
            this.gvStaff.AutoGenerateColumns = false;
            this.gvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.gvStaff.DataSource = this.staffBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvStaff.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvStaff.EnableHeadersVisualStyles = false;
            this.gvStaff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvStaff.Location = new System.Drawing.Point(4, 92);
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvStaff.RowTemplate.Height = 24;
            this.gvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStaff.Size = new System.Drawing.Size(628, 231);
            this.gvStaff.TabIndex = 21;
            this.gvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStaff_CellContentClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "StaffAddress";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "StaffAddress";
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.kFCDataSet1;
            // 
            // kFCDataSet1
            // 
            this.kFCDataSet1.DataSetName = "KFCDataSet1";
            this.kFCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.129032F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(1181, 618);
            this.Load += new System.EventHandler(this.StaffUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private MetroFramework.Controls.MetroTextBox txtSearchStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtStaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtStaffAddress;
        private MetroFramework.Controls.MetroTextBox txtStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private MetroFramework.Controls.MetroDateTime txtDOB;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid gvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private KFCDataSet1 kFCDataSet1;
        private KFCDataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
    }
}
