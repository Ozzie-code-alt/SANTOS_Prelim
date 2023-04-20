namespace SANTOS_Prelim
{
    partial class EmployeePortalForm
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.welcomBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WelcomtxtUsername = new System.Windows.Forms.TextBox();
            this.WElcomeTxtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnWelcomeLogin = new System.Windows.Forms.Button();
            this.TXTWElcomEployeeType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 40.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(534, 184);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(240, 68);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // welcomBTN
            // 
            this.welcomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcomBTN.Location = new System.Drawing.Point(560, 461);
            this.welcomBTN.Name = "welcomBTN";
            this.welcomBTN.Size = new System.Drawing.Size(214, 34);
            this.welcomBTN.TabIndex = 1;
            this.welcomBTN.Text = "Get Started";
            this.welcomBTN.UseVisualStyleBackColor = true;
            this.welcomBTN.Click += new System.EventHandler(this.welcomBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // WelcomtxtUsername
            // 
            this.WelcomtxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WelcomtxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomtxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomtxtUsername.ForeColor = System.Drawing.Color.White;
            this.WelcomtxtUsername.Location = new System.Drawing.Point(585, 337);
            this.WelcomtxtUsername.Name = "WelcomtxtUsername";
            this.WelcomtxtUsername.Size = new System.Drawing.Size(182, 22);
            this.WelcomtxtUsername.TabIndex = 4;
            // 
            // WElcomeTxtPass
            // 
            this.WElcomeTxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WElcomeTxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WElcomeTxtPass.ForeColor = System.Drawing.Color.White;
            this.WElcomeTxtPass.Location = new System.Drawing.Point(585, 379);
            this.WElcomeTxtPass.Name = "WElcomeTxtPass";
            this.WElcomeTxtPass.Size = new System.Drawing.Size(182, 22);
            this.WElcomeTxtPass.TabIndex = 5;
            this.WElcomeTxtPass.TextChanged += new System.EventHandler(this.WElcomeTxtPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "or";
            // 
            // BtnWelcomeLogin
            // 
            this.BtnWelcomeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWelcomeLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnWelcomeLogin.Location = new System.Drawing.Point(797, 379);
            this.BtnWelcomeLogin.Name = "BtnWelcomeLogin";
            this.BtnWelcomeLogin.Size = new System.Drawing.Size(77, 31);
            this.BtnWelcomeLogin.TabIndex = 7;
            this.BtnWelcomeLogin.Text = "Login";
            this.BtnWelcomeLogin.UseVisualStyleBackColor = true;
            this.BtnWelcomeLogin.Click += new System.EventHandler(this.BtnWelcomeLogin_Click);
            // 
            // TXTWElcomEployeeType
            // 
            this.TXTWElcomEployeeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TXTWElcomEployeeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTWElcomEployeeType.Enabled = false;
            this.TXTWElcomEployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTWElcomEployeeType.ForeColor = System.Drawing.Color.White;
            this.TXTWElcomEployeeType.Location = new System.Drawing.Point(950, 461);
            this.TXTWElcomEployeeType.Multiline = true;
            this.TXTWElcomEployeeType.Name = "TXTWElcomEployeeType";
            this.TXTWElcomEployeeType.Size = new System.Drawing.Size(145, 26);
            this.TXTWElcomEployeeType.TabIndex = 8;
            this.TXTWElcomEployeeType.TextChanged += new System.EventHandler(this.TXTWElcomEployeeType_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "EmployeeType:";
            // 
            // EmployeePortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1323, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTWElcomEployeeType);
            this.Controls.Add(this.BtnWelcomeLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WElcomeTxtPass);
            this.Controls.Add(this.WelcomtxtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomBTN);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePortalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePortal";
            this.Load += new System.EventHandler(this.EmployeePortalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button welcomBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WelcomtxtUsername;
        private System.Windows.Forms.TextBox WElcomeTxtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnWelcomeLogin;
        private System.Windows.Forms.TextBox TXTWElcomEployeeType;
        private System.Windows.Forms.Label label4;
    }
}

