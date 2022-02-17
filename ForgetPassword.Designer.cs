namespace KFC
{
    partial class ForgetPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtVerifyCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(321, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "atboy769@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "We sent your code to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Please check your email for a message with your code. Your code is 6 numbers long" +
    ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter security code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please enter your email to reset your password.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSendCode);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 312);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSendCode
            // 
            this.btnSendCode.ActiveBorderThickness = 1;
            this.btnSendCode.ActiveCornerRadius = 2;
            this.btnSendCode.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnSendCode.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendCode.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSendCode.BackColor = System.Drawing.Color.White;
            this.btnSendCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendCode.BackgroundImage")));
            this.btnSendCode.ButtonText = "Send Code";
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.03226F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.IdleBorderThickness = 3;
            this.btnSendCode.IdleCornerRadius = 1;
            this.btnSendCode.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnSendCode.IdleForecolor = System.Drawing.Color.White;
            this.btnSendCode.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSendCode.Location = new System.Drawing.Point(339, 219);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(143, 64);
            this.btnSendCode.TabIndex = 31;
            this.btnSendCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendCode.Click += new System.EventHandler(this.BtnSendCode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(112, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 54);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Text = "Enter your Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Forget Paassword";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.txtVerifyCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(55, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 312);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnContinue
            // 
            this.btnContinue.ActiveBorderThickness = 1;
            this.btnContinue.ActiveCornerRadius = 2;
            this.btnContinue.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinue.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.ButtonText = "Continue";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.03226F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.IdleBorderThickness = 3;
            this.btnContinue.IdleCornerRadius = 1;
            this.btnContinue.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnContinue.IdleForecolor = System.Drawing.Color.White;
            this.btnContinue.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnContinue.Location = new System.Drawing.Point(99, 207);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(143, 64);
            this.btnContinue.TabIndex = 30;
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click_1);
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtVerifyCode.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtVerifyCode.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtVerifyCode.BorderThickness = 3;
            this.txtVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerifyCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVerifyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerifyCode.isPassword = false;
            this.txtVerifyCode.Location = new System.Drawing.Point(26, 129);
            this.txtVerifyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(216, 54);
            this.txtVerifyCode.TabIndex = 30;
            this.txtVerifyCode.Text = "Enter 6 digit code";
            this.txtVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 42);
            this.panel3.TabIndex = 24;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 407);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVerifyCode;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinue;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendCode;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private System.Windows.Forms.Panel panel3;

        // private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}