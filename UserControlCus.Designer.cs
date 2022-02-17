namespace KFC
{
    partial class UserControlCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerID = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kFCDataSet = new KFC.KFCDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.customerTableAdapter = new KFC.KFCDataSetTableAdapters.CustomerTableAdapter();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCustomer = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.93548F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(270, 251);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(261, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtCustomerID
            // 
            // 
            // 
            // 
            this.txtCustomerID.CustomButton.Image = null;
            this.txtCustomerID.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtCustomerID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.CustomButton.Name = "";
            this.txtCustomerID.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerID.CustomButton.TabIndex = 1;
            this.txtCustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerID.CustomButton.UseSelectable = true;
            this.txtCustomerID.CustomButton.Visible = false;
            this.txtCustomerID.Lines = new string[0];
            this.txtCustomerID.Location = new System.Drawing.Point(270, 31);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.MaxLength = 32767;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.SelectionLength = 0;
            this.txtCustomerID.SelectionStart = 0;
            this.txtCustomerID.ShortcutsEnabled = true;
            this.txtCustomerID.Size = new System.Drawing.Size(261, 33);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.UseSelectable = true;
            this.txtCustomerID.Visible = false;
            this.txtCustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerID.Click += new System.EventHandler(this.txtCustomerID_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 395);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.gvCustomer);
            this.metroPanel2.Controls.Add(this.pictureBox3);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnEdit);
            this.metroPanel2.Controls.Add(this.txtSearchCustomer);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 13;
            this.metroPanel2.Location = new System.Drawing.Point(575, 68);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(595, 526);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 12;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.kFCDataSet;
            // 
            // kFCDataSet
            // 
            this.kFCDataSet.DataSetName = "KFCDataSet";
            this.kFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 395);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(289, 375);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 97);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(20, 375);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(261, 97);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchCustomer
            // 
            // 
            // 
            // 
            this.txtSearchCustomer.CustomButton.Image = null;
            this.txtSearchCustomer.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtSearchCustomer.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.CustomButton.Name = "";
            this.txtSearchCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCustomer.CustomButton.TabIndex = 1;
            this.txtSearchCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCustomer.CustomButton.UseSelectable = true;
            this.txtSearchCustomer.CustomButton.Visible = false;
            this.txtSearchCustomer.Lines = new string[0];
            this.txtSearchCustomer.Location = new System.Drawing.Point(184, 28);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.MaxLength = 32767;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.SelectionLength = 0;
            this.txtSearchCustomer.SelectionStart = 0;
            this.txtSearchCustomer.ShortcutsEnabled = true;
            this.txtSearchCustomer.Size = new System.Drawing.Size(209, 27);
            this.txtSearchCustomer.TabIndex = 3;
            this.txtSearchCustomer.UseSelectable = true;
            this.txtSearchCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            this.txtSearchCustomer.Click += new System.EventHandler(this.txtSearchCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Search Customer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.txtCustomerName);
            this.metroPanel1.Controls.Add(this.txtCustomerAddress);
            this.metroPanel1.Controls.Add(this.txtContact);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtCustomerID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 13;
            this.metroPanel1.Location = new System.Drawing.Point(10, 68);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(557, 526);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 395);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(270, 375);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 97);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtCustomerName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(270, 86);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(261, 33);
            this.txtCustomerName.TabIndex = 6;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.Click += new System.EventHandler(this.txtCustomerName_Click);
            // 
            // txtCustomerAddress
            // 
            // 
            // 
            // 
            this.txtCustomerAddress.CustomButton.Image = null;
            this.txtCustomerAddress.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtCustomerAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.CustomButton.Name = "";
            this.txtCustomerAddress.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerAddress.CustomButton.TabIndex = 1;
            this.txtCustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerAddress.CustomButton.UseSelectable = true;
            this.txtCustomerAddress.CustomButton.Visible = false;
            this.txtCustomerAddress.Lines = new string[0];
            this.txtCustomerAddress.Location = new System.Drawing.Point(270, 141);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.MaxLength = 32767;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.PasswordChar = '\0';
            this.txtCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerAddress.SelectedText = "";
            this.txtCustomerAddress.SelectionLength = 0;
            this.txtCustomerAddress.SelectionStart = 0;
            this.txtCustomerAddress.ShortcutsEnabled = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(261, 33);
            this.txtCustomerAddress.TabIndex = 5;
            this.txtCustomerAddress.UseSelectable = true;
            this.txtCustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerAddress.Click += new System.EventHandler(this.txtCustomerAddress_Click);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtContact.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(270, 196);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(261, 33);
            this.txtContact.TabIndex = 4;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.Click += new System.EventHandler(this.txtContact_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 66;
            // 
            // contactNumberDataGridViewTextBoxColumn1
            // 
            this.contactNumberDataGridViewTextBoxColumn1.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn1.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn1.Name = "contactNumberDataGridViewTextBoxColumn1";
            this.contactNumberDataGridViewTextBoxColumn1.Width = 123;
            // 
            // customerAddressDataGridViewTextBoxColumn1
            // 
            this.customerAddressDataGridViewTextBoxColumn1.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn1.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn1.Name = "customerAddressDataGridViewTextBoxColumn1";
            this.customerAddressDataGridViewTextBoxColumn1.Width = 131;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.Width = 121;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gvCustomer
            // 
            this.gvCustomer.AutoGenerateColumns = false;
            this.gvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.customerAddressDataGridViewTextBoxColumn1,
            this.contactNumberDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.gvCustomer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCustomer.EnableHeadersVisualStyles = false;
            this.gvCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvCustomer.Location = new System.Drawing.Point(3, 87);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvCustomer.RowTemplate.Height = 24;
            this.gvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomer.Size = new System.Drawing.Size(585, 254);
            this.gvCustomer.TabIndex = 20;
            this.gvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomer_CellContentClick);
            // 
            // UserControlCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.129032F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlCus";
            this.Size = new System.Drawing.Size(1183, 605);
            this.Load += new System.EventHandler(this.UserControlCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCustomerID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private MetroFramework.Controls.MetroTextBox txtSearchCustomer;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerAddress;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private KFCDataSet kFCDataSet;
        private KFCDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private MetroFramework.Controls.MetroGrid gvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
    }
}
