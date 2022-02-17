namespace KFC
{
    partial class NewPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPass));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtVerifyPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txtVerifyPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(74, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(483, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a new password";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 2;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.White;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.03226F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IdleBorderThickness = 3;
            this.btnConfirm.IdleCornerRadius = 1;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.IdleForecolor = System.Drawing.Color.White;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(278, 214);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 67);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click_1);
            // 
            // txtVerifyPass
            // 
            this.txtVerifyPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerifyPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVerifyPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerifyPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtVerifyPass.HintText = "";
            this.txtVerifyPass.isPassword = false;
            this.txtVerifyPass.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtVerifyPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVerifyPass.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtVerifyPass.LineThickness = 3;
            this.txtVerifyPass.Location = new System.Drawing.Point(42, 131);
            this.txtVerifyPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerifyPass.Name = "txtVerifyPass";
            this.txtVerifyPass.Size = new System.Drawing.Size(379, 45);
            this.txtVerifyPass.TabIndex = 4;
            this.txtVerifyPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVerifyPass.MouseEnter += new System.EventHandler(this.TxtVerifyPass_MouseEnter);
            this.txtVerifyPass.MouseLeave += new System.EventHandler(this.TxtVerifyPass_MouseLeave);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPass.HintText = "";
            this.txtNewPass.isPassword = false;
            this.txtNewPass.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtNewPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPass.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtNewPass.LineThickness = 3;
            this.txtNewPass.Location = new System.Drawing.Point(42, 65);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(379, 45);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPass.OnValueChanged += new System.EventHandler(this.TxtNewPass_OnValueChanged_1);
            this.txtNewPass.MouseEnter += new System.EventHandler(this.TxtNewPass_MouseEnter);
            this.txtNewPass.MouseLeave += new System.EventHandler(this.TxtNewPass_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 54);
            this.panel1.TabIndex = 1;
            // 
            // NewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPass";
            this.Load += new System.EventHandler(this.NewPass_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVerifyPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.Panel panel1;
    }
}