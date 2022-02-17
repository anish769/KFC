namespace KFC
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));

            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
        
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtCustomerID = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTableAdapter
            // 

            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Search Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 372);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(270, 353);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 91);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 372);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 372);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(289, 353);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 91);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(20, 353);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(261, 91);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(184, 26);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(209, 25);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kFCDataSet1
            // 
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.870968F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.pictureBox3);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnEdit);
            this.metroPanel2.Controls.Add(this.metroTextBox1);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(608, 83);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(551, 495);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 12;
            // 
            // txtCustomerID
            // 
            // 
            // 
            // 
            this.txtCustomerID.CustomButton.Image = null;
            this.txtCustomerID.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCustomerID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.CustomButton.Name = "";
            this.txtCustomerID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerID.CustomButton.TabIndex = 1;
            this.txtCustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerID.CustomButton.UseSelectable = true;
            this.txtCustomerID.CustomButton.Visible = false;
            this.txtCustomerID.Lines = new string[0];
            this.txtCustomerID.Location = new System.Drawing.Point(270, 29);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.MaxLength = 32767;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.SelectionLength = 0;
            this.txtCustomerID.SelectionStart = 0;
            this.txtCustomerID.ShortcutsEnabled = true;
            this.txtCustomerID.Size = new System.Drawing.Size(261, 31);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.UseSelectable = true;
            this.txtCustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.93548F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Details";
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCustomerName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(270, 81);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(261, 31);
            this.txtCustomerName.TabIndex = 6;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerAddress
            // 
            // 
            // 
            // 
            this.txtCustomerAddress.CustomButton.Image = null;
            this.txtCustomerAddress.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCustomerAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.CustomButton.Name = "";
            this.txtCustomerAddress.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerAddress.CustomButton.TabIndex = 1;
            this.txtCustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerAddress.CustomButton.UseSelectable = true;
            this.txtCustomerAddress.CustomButton.Visible = false;
            this.txtCustomerAddress.Lines = new string[0];
            this.txtCustomerAddress.Location = new System.Drawing.Point(270, 133);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.MaxLength = 32767;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.PasswordChar = '\0';
            this.txtCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerAddress.SelectedText = "";
            this.txtCustomerAddress.SelectionLength = 0;
            this.txtCustomerAddress.SelectionStart = 0;
            this.txtCustomerAddress.ShortcutsEnabled = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(261, 31);
            this.txtCustomerAddress.TabIndex = 5;
            this.txtCustomerAddress.UseSelectable = true;
            this.txtCustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtContact.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(270, 184);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(261, 31);
            this.txtContact.TabIndex = 4;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.txtCustomerName);
            this.metroPanel1.Controls.Add(this.txtCustomerAddress);
            this.metroPanel1.Controls.Add(this.txtContact);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtCustomerID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(-10, 83);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(601, 495);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(270, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(261, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customerBindingSource
            // 
           
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroPanel1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1162, 617);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();

            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
  
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerAddress;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}
