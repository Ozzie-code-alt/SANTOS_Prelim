namespace SANTOS_Prelim
{
    partial class HostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Product = new System.Windows.Forms.TabPage();
            this.dgvCusOrder = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.TabPage();
            this.dgvCUSTOMERProfile = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMemberlist = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTCusID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpadmin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnClearAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.AdminAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.AdminPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.AdminQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.AdminModelTxtBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AdminBrandTxtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AdminProductTxtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTHOST = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btnrefresh = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtGenerateReceipt = new System.Windows.Forms.RichTextBox();
            this.TXTCUSTOMER = new System.Windows.Forms.TextBox();
            this.txtChecker1 = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnmembersignup = new System.Windows.Forms.Button();
            this.txtmembership = new System.Windows.Forms.TextBox();
            this.txtpassblank = new System.Windows.Forms.TextBox();
            this.txtConfirmationtxt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusOrder)).BeginInit();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMERProfile)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCS Computer Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1114, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Lopez Jaena Street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ILOILO, City Philippines";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 38);
            this.label10.TabIndex = 10;
            this.label10.Text = "HOST";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1405, 583);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(146, 23);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Print receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Product);
            this.tabControl1.Controls.Add(this.Customer);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(887, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 480);
            this.tabControl1.TabIndex = 61;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.dgvCusOrder);
            this.Product.Controls.Add(this.label3);
            this.Product.Location = new System.Drawing.Point(4, 25);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(851, 451);
            this.Product.TabIndex = 0;
            this.Product.Text = "Customer Order";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // dgvCusOrder
            // 
            this.dgvCusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvCusOrder.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.dgvCusOrder.Name = "dgvCusOrder";
            this.dgvCusOrder.RowHeadersWidth = 51;
            this.dgvCusOrder.RowTemplate.Height = 24;
            this.dgvCusOrder.Size = new System.Drawing.Size(1047, 454);
            this.dgvCusOrder.TabIndex = 29;
            this.dgvCusOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusOrder_CellClick);
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.dgvCUSTOMERProfile);
            this.Customer.Location = new System.Drawing.Point(4, 25);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(851, 451);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "Customer Profile";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // dgvCUSTOMERProfile
            // 
            this.dgvCUSTOMERProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCUSTOMERProfile.Location = new System.Drawing.Point(3, 3);
            this.dgvCUSTOMERProfile.Name = "dgvCUSTOMERProfile";
            this.dgvCUSTOMERProfile.RowHeadersWidth = 51;
            this.dgvCUSTOMERProfile.RowTemplate.Height = 24;
            this.dgvCUSTOMERProfile.Size = new System.Drawing.Size(1043, 444);
            this.dgvCUSTOMERProfile.TabIndex = 0;
            this.dgvCUSTOMERProfile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCUSTOMERProfile_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMemberlist);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 451);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMemberlist
            // 
            this.dgvMemberlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberlist.Location = new System.Drawing.Point(2, 3);
            this.dgvMemberlist.Name = "dgvMemberlist";
            this.dgvMemberlist.RowHeadersWidth = 51;
            this.dgvMemberlist.RowTemplate.Height = 24;
            this.dgvMemberlist.Size = new System.Drawing.Size(1043, 444);
            this.dgvMemberlist.TabIndex = 1;
            this.dgvMemberlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberlist_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(131, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 29);
            this.label15.TabIndex = 59;
            this.label15.Text = "Host:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 400);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 29);
            this.label14.TabIndex = 57;
            this.label14.Text = "Customer:";
            // 
            // TXTCusID
            // 
            this.TXTCusID.Location = new System.Drawing.Point(209, 314);
            this.TXTCusID.Name = "TXTCusID";
            this.TXTCusID.Size = new System.Drawing.Size(192, 22);
            this.TXTCusID.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 29);
            this.label13.TabIndex = 55;
            this.label13.Text = "Customer ID:";
            // 
            // dtpadmin
            // 
            this.dtpadmin.Location = new System.Drawing.Point(209, 257);
            this.dtpadmin.Name = "dtpadmin";
            this.dtpadmin.Size = new System.Drawing.Size(264, 22);
            this.dtpadmin.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 29);
            this.label12.TabIndex = 53;
            this.label12.Text = "Date Time:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(209, 205);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(192, 22);
            this.txtOrderNum.TabIndex = 52;
            this.txtOrderNum.TextChanged += new System.EventHandler(this.txtOrderNum_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "Order Number:";
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(1292, 711);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAdmin.TabIndex = 77;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnClearAdmin
            // 
            this.btnClearAdmin.Location = new System.Drawing.Point(1292, 665);
            this.btnClearAdmin.Name = "btnClearAdmin";
            this.btnClearAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnClearAdmin.TabIndex = 76;
            this.btnClearAdmin.Text = "Clear";
            this.btnClearAdmin.UseVisualStyleBackColor = true;
            this.btnClearAdmin.Click += new System.EventHandler(this.btnClearAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(1292, 618);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 75;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // AdminAmountTxtBox
            // 
            this.AdminAmountTxtBox.Enabled = false;
            this.AdminAmountTxtBox.Location = new System.Drawing.Point(1016, 733);
            this.AdminAmountTxtBox.Name = "AdminAmountTxtBox";
            this.AdminAmountTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminAmountTxtBox.TabIndex = 74;
            this.AdminAmountTxtBox.Visible = false;
            this.AdminAmountTxtBox.TextChanged += new System.EventHandler(this.AdminAmountTxtBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(896, 726);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 29);
            this.label20.TabIndex = 73;
            this.label20.Text = "Amount:";
            this.label20.Visible = false;
            // 
            // AdminPriceTxtBox
            // 
            this.AdminPriceTxtBox.Location = new System.Drawing.Point(1016, 666);
            this.AdminPriceTxtBox.Name = "AdminPriceTxtBox";
            this.AdminPriceTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminPriceTxtBox.TabIndex = 72;
            this.AdminPriceTxtBox.Visible = false;
            this.AdminPriceTxtBox.TextChanged += new System.EventHandler(this.AdminPriceTxtBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(926, 658);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 29);
            this.label21.TabIndex = 71;
            this.label21.Text = "Price:";
            this.label21.Visible = false;
            // 
            // AdminQuantityTxtBox
            // 
            this.AdminQuantityTxtBox.Location = new System.Drawing.Point(626, 734);
            this.AdminQuantityTxtBox.Name = "AdminQuantityTxtBox";
            this.AdminQuantityTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminQuantityTxtBox.TabIndex = 70;
            this.AdminQuantityTxtBox.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(506, 727);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 29);
            this.label19.TabIndex = 69;
            this.label19.Text = "Quantity:";
            this.label19.Visible = false;
            // 
            // AdminModelTxtBox
            // 
            this.AdminModelTxtBox.Location = new System.Drawing.Point(626, 665);
            this.AdminModelTxtBox.Name = "AdminModelTxtBox";
            this.AdminModelTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminModelTxtBox.TabIndex = 68;
            this.AdminModelTxtBox.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(523, 658);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 29);
            this.label18.TabIndex = 67;
            this.label18.Text = "Model:";
            this.label18.Visible = false;
            // 
            // AdminBrandTxtBox
            // 
            this.AdminBrandTxtBox.Location = new System.Drawing.Point(243, 733);
            this.AdminBrandTxtBox.Name = "AdminBrandTxtBox";
            this.AdminBrandTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminBrandTxtBox.TabIndex = 66;
            this.AdminBrandTxtBox.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(140, 726);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 29);
            this.label17.TabIndex = 65;
            this.label17.Text = "Brand:";
            this.label17.Visible = false;
            // 
            // AdminProductTxtBox
            // 
            this.AdminProductTxtBox.Location = new System.Drawing.Point(243, 664);
            this.AdminProductTxtBox.Name = "AdminProductTxtBox";
            this.AdminProductTxtBox.Size = new System.Drawing.Size(192, 22);
            this.AdminProductTxtBox.TabIndex = 64;
            this.AdminProductTxtBox.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(130, 657);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 29);
            this.label16.TabIndex = 63;
            this.label16.Text = "Product:";
            this.label16.Visible = false;
            // 
            // TXTHOST
            // 
            this.TXTHOST.FormattingEnabled = true;
            this.TXTHOST.Location = new System.Drawing.Point(209, 363);
            this.TXTHOST.Name = "TXTHOST";
            this.TXTHOST.Size = new System.Drawing.Size(192, 24);
            this.TXTHOST.TabIndex = 79;
            this.TXTHOST.SelectedIndexChanged += new System.EventHandler(this.TXTHOST_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btnrefresh
            // 
            this.Btnrefresh.Location = new System.Drawing.Point(561, 583);
            this.Btnrefresh.Name = "Btnrefresh";
            this.Btnrefresh.Size = new System.Drawing.Size(75, 25);
            this.Btnrefresh.TabIndex = 80;
            this.Btnrefresh.Text = "refresh ";
            this.Btnrefresh.UseVisualStyleBackColor = true;
            this.Btnrefresh.Click += new System.EventHandler(this.Btnrefresh_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtGenerateReceipt
            // 
            this.txtGenerateReceipt.Location = new System.Drawing.Point(1657, 12);
            this.txtGenerateReceipt.Name = "txtGenerateReceipt";
            this.txtGenerateReceipt.Size = new System.Drawing.Size(100, 96);
            this.txtGenerateReceipt.TabIndex = 81;
            this.txtGenerateReceipt.Text = "";
            this.txtGenerateReceipt.Visible = false;
            // 
            // TXTCUSTOMER
            // 
            this.TXTCUSTOMER.Location = new System.Drawing.Point(209, 408);
            this.TXTCUSTOMER.Name = "TXTCUSTOMER";
            this.TXTCUSTOMER.Size = new System.Drawing.Size(192, 22);
            this.TXTCUSTOMER.TabIndex = 83;
            this.TXTCUSTOMER.TextChanged += new System.EventHandler(this.TXTCUSTOMER_TextChanged_1);
            // 
            // txtChecker1
            // 
            this.txtChecker1.Enabled = false;
            this.txtChecker1.Location = new System.Drawing.Point(444, 408);
            this.txtChecker1.Name = "txtChecker1";
            this.txtChecker1.Size = new System.Drawing.Size(192, 22);
            this.txtChecker1.TabIndex = 84;
            this.txtChecker1.TextChanged += new System.EventHandler(this.txtChecker1_TextChanged);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Enabled = false;
            this.txtPrompt.Location = new System.Drawing.Point(28, 493);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(719, 22);
            this.txtPrompt.TabIndex = 85;
            this.txtPrompt.Text = "Whoa!, a customer are you interested with upgrading your account to member for 10" +
    "% off for all your purchase?";
            this.txtPrompt.Visible = false;
            // 
            // btnmembersignup
            // 
            this.btnmembersignup.Location = new System.Drawing.Point(291, 558);
            this.btnmembersignup.Name = "btnmembersignup";
            this.btnmembersignup.Size = new System.Drawing.Size(110, 25);
            this.btnmembersignup.TabIndex = 86;
            this.btnmembersignup.Text = "Member ";
            this.btnmembersignup.UseVisualStyleBackColor = true;
            this.btnmembersignup.Visible = false;
            this.btnmembersignup.Click += new System.EventHandler(this.btnmembersignup_Click);
            // 
            // txtmembership
            // 
            this.txtmembership.Location = new System.Drawing.Point(35, 547);
            this.txtmembership.Name = "txtmembership";
            this.txtmembership.Size = new System.Drawing.Size(217, 22);
            this.txtmembership.TabIndex = 87;
            // 
            // txtpassblank
            // 
            this.txtpassblank.Enabled = false;
            this.txtpassblank.Location = new System.Drawing.Point(1459, 27);
            this.txtpassblank.Name = "txtpassblank";
            this.txtpassblank.Size = new System.Drawing.Size(192, 22);
            this.txtpassblank.TabIndex = 88;
            this.txtpassblank.Visible = false;
            // 
            // txtConfirmationtxt
            // 
            this.txtConfirmationtxt.AutoSize = true;
            this.txtConfirmationtxt.Location = new System.Drawing.Point(25, 592);
            this.txtConfirmationtxt.Name = "txtConfirmationtxt";
            this.txtConfirmationtxt.Size = new System.Drawing.Size(241, 16);
            this.txtConfirmationtxt.TabIndex = 89;
            this.txtConfirmationtxt.Text = "Please Type \"Member\" for confirmation";
            this.txtConfirmationtxt.Visible = false;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1778, 805);
            this.Controls.Add(this.txtConfirmationtxt);
            this.Controls.Add(this.txtpassblank);
            this.Controls.Add(this.txtmembership);
            this.Controls.Add(this.btnmembersignup);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtChecker1);
            this.Controls.Add(this.TXTCUSTOMER);
            this.Controls.Add(this.txtGenerateReceipt);
            this.Controls.Add(this.Btnrefresh);
            this.Controls.Add(this.TXTHOST);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnClearAdmin);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.AdminAmountTxtBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AdminPriceTxtBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.AdminQuantityTxtBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.AdminModelTxtBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AdminBrandTxtBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.AdminProductTxtBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TXTCusID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpadmin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HostForm";
            this.Text = "HostForm";
            this.tabControl1.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusOrder)).EndInit();
            this.Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMERProfile)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.DataGridView dgvCusOrder;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.DataGridView dgvCUSTOMERProfile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTCusID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpadmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnClearAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox AdminAmountTxtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AdminPriceTxtBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox AdminQuantityTxtBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox AdminModelTxtBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AdminBrandTxtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AdminProductTxtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox TXTHOST;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btnrefresh;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RichTextBox txtGenerateReceipt;
        private System.Windows.Forms.TextBox TXTCUSTOMER;
        private System.Windows.Forms.TextBox txtChecker1;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnmembersignup;
        private System.Windows.Forms.TextBox txtmembership;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvMemberlist;
        private System.Windows.Forms.TextBox txtpassblank;
        private System.Windows.Forms.Label txtConfirmationtxt;
    }
}