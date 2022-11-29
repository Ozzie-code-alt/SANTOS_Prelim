namespace SANTOS_Prelim
{
    partial class employeeRole
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
            this.btnPortalHost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnPortalAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTempName = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTempPass = new System.Windows.Forms.TextBox();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.txtChecker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminChecker = new System.Windows.Forms.TextBox();
            this.btnaddCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPortalHost
            // 
            this.btnPortalHost.Location = new System.Drawing.Point(269, 236);
            this.btnPortalHost.Name = "btnPortalHost";
            this.btnPortalHost.Size = new System.Drawing.Size(214, 23);
            this.btnPortalHost.TabIndex = 3;
            this.btnPortalHost.Text = "Host";
            this.btnPortalHost.UseVisualStyleBackColor = true;
            this.btnPortalHost.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Signup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // btnPortalAdmin
            // 
            this.btnPortalAdmin.Location = new System.Drawing.Point(269, 281);
            this.btnPortalAdmin.Name = "btnPortalAdmin";
            this.btnPortalAdmin.Size = new System.Drawing.Size(214, 23);
            this.btnPortalAdmin.TabIndex = 4;
            this.btnPortalAdmin.Text = "Administrator";
            this.btnPortalAdmin.UseVisualStyleBackColor = true;
            this.btnPortalAdmin.Click += new System.EventHandler(this.btnPortalAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "or";
            // 
            // TXTempName
            // 
            this.TXTempName.Location = new System.Drawing.Point(297, 108);
            this.TXTempName.Name = "TXTempName";
            this.TXTempName.Size = new System.Drawing.Size(173, 22);
            this.TXTempName.TabIndex = 6;
            // 
            // txtEName
            // 
            this.txtEName.AutoSize = true;
            this.txtEName.Location = new System.Drawing.Point(212, 108);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(79, 16);
            this.txtEName.TabIndex = 7;
            this.txtEName.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account Password:";
            // 
            // TXTempPass
            // 
            this.TXTempPass.Location = new System.Drawing.Point(297, 195);
            this.TXTempPass.Name = "TXTempPass";
            this.TXTempPass.Size = new System.Drawing.Size(173, 22);
            this.TXTempPass.TabIndex = 8;
            this.TXTempPass.TextChanged += new System.EventHandler(this.TXTempPass_TextChanged_1);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // txtChecker
            // 
            this.txtChecker.Enabled = false;
            this.txtChecker.Location = new System.Drawing.Point(522, 204);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(173, 22);
            this.txtChecker.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input Admin Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminChecker
            // 
            this.AdminChecker.Location = new System.Drawing.Point(297, 151);
            this.AdminChecker.Name = "AdminChecker";
            this.AdminChecker.Size = new System.Drawing.Size(173, 22);
            this.AdminChecker.TabIndex = 12;
            // 
            // btnaddCustomer
            // 
            this.btnaddCustomer.Location = new System.Drawing.Point(269, 329);
            this.btnaddCustomer.Name = "btnaddCustomer";
            this.btnaddCustomer.Size = new System.Drawing.Size(214, 23);
            this.btnaddCustomer.TabIndex = 13;
            this.btnaddCustomer.Text = "Customer";
            this.btnaddCustomer.UseVisualStyleBackColor = true;
            this.btnaddCustomer.Click += new System.EventHandler(this.btnaddCustomer_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "or";
            // 
            // employeeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(727, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnaddCustomer);
            this.Controls.Add(this.AdminChecker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChecker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTempPass);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.TXTempName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPortalAdmin);
            this.Controls.Add(this.btnPortalHost);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeRole";
            this.Opacity = 0D;
            this.Text = "employeeRole";
            this.Load += new System.EventHandler(this.employeeRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPortalHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Button btnPortalAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTempName;
        private System.Windows.Forms.Label txtEName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTempPass;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminChecker;
        private System.Windows.Forms.Button btnaddCustomer;
        private System.Windows.Forms.Label label5;
    }
}