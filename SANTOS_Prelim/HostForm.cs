using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANTOS_Prelim
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        //Customer 
        SQLiteDataAdapter DB2;
        DataSet DS2 = new DataSet();
        DataTable DT2 = new DataTable();

        //Customer Accounts


        //employee
        SQLiteDataAdapter DB1;
        DataSet DS1 = new DataSet();
        DataTable DT1 = new DataTable();

        //admin 
        SQLiteDataAdapter DB;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void setConnection()
        {
            sql_con = new SQLiteConnection("Data Source = MidtermDB.db");

        }

        private void LoadData()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();


            //employeeListDGV 
            string CommandText1 = "select * from Accounts"; //select from table
            DB1 = new SQLiteDataAdapter(CommandText1, sql_con);
            DS1.Reset();
            DB1.Fill(DS1); //determine the data set
            DT1 = DS1.Tables[0]; //which row from db

           dgvMemberlist.DataSource = DT1;
            TXTHOST.DataSource = DT1;
            TXTHOST.DisplayMember = "Username";// can display any member u want
            TXTHOST.ValueMember = "Username";


            
            string CommandText = "select * from Administrator"; //select from table
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS); //determine the data set
            DT = DS.Tables[0]; //which row from db
            dgvCusOrder.DataSource = DT; //load table data


            /*      //employeeListDGV 
                  string CommandText1 = "select * from Accounts"; //select from table
                  DB1 = new SQLiteDataAdapter(CommandText1, sql_con);
                  DS1.Reset();
                  DB1.Fill(DS1); //determine the data set
                  DT1 = DS1.Tables[0]; //which row from db
                  *//*.DataSource = DT; //load table data*//**/

            /*  dgvEmployee.DataSource = DT1; //load table data*/



            string CommandText2 = "select * from Customer"; //select from table
            DB2 = new SQLiteDataAdapter(CommandText2, sql_con);
            DS2.Reset();
            DB2.Fill(DS2); //determine the data set
            DT2 = DS2.Tables[0]; //which row from db
            dgvCUSTOMERProfile.DataSource = DT2; //load table data

           
            sql_con.Close();

        }

        //add as  much for multiple txtQueries
        private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();

        }
     
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
           

            string txtQuery = "insert into Administrator (Product, Brand, Model, Quantity, Price, Amount) values ('" + AdminProductTxtBox.Text + "', '" + AdminBrandTxtBox.Text + "', '" + AdminModelTxtBox.Text + "', '" + AdminQuantityTxtBox.Text + "', '" + AdminPriceTxtBox.Text + "', '" + AdminAmountTxtBox.Text + "' )";
            ExecuteQuery(txtQuery);
           /* string txtQuery1 = "insert into Customer(OrderNum,Date, CustomerID, Customer, Host) values ('" + txtOrderNum.Text + "','" + dtpadmin.Text + "', '" + TXTCusID.Text + "', '" + TXTCUSTOMER.Text + "', '" + TXTHOST.Text + "') ";
            ExecuteQuery1(txtQuery1);*/
           
            
            string txtQuery1 = "insert into Customer (OrderNum,Date, CustomerID, Customer, Host) values ('" + txtOrderNum.Text + "','" + dtpadmin.Text + "', '" + TXTCusID.Text + "', '" + TXTCUSTOMER.Text + "', '" + TXTHOST.Text + "') ";
            ExecuteQuery(txtQuery1);
            LoadData();
            MessageBox.Show("Added");


            txtGenerateReceipt.Clear();
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "****                  CCS Computer Shop              ****\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "****                  CPU Lopez Jaena Street         ****\n";
            txtGenerateReceipt.Text += "****                  IloiloCity Philippines         ****\n";
            txtGenerateReceipt.Text += "****                           5000                  ****\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "****                   TELEPHONE # (033)329-1971     ****\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "****                       Serial Number:            ****\n";
            txtGenerateReceipt.Text += "****                       1234567890abc             ****\n";
            txtGenerateReceipt.Text += "****                       Permit Number:            ****\n";
            txtGenerateReceipt.Text += "****                       ABCD123456789             ****\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "****                       Order Receipt             ****\n";
            txtGenerateReceipt.Text += "Order No: " + txtOrderNum.Text + "\n \n";
            txtGenerateReceipt.Text += "Date: " + dtpadmin.Text + "\n \n";
            txtGenerateReceipt.Text += "Customer ID: " + TXTCusID.Text + "\n \n";
            txtGenerateReceipt.Text += "Customer: " + TXTCUSTOMER.Text + "\n \n";
            txtGenerateReceipt.Text += "Host: " + TXTHOST.Text + "\n \n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "*********************************************************\n";
            txtGenerateReceipt.Text += "Product: " + AdminProductTxtBox.Text + "\n \n";
            txtGenerateReceipt.Text += "Brand: " + AdminBrandTxtBox.Text + "\n \n";
            txtGenerateReceipt.Text += "Model: " + AdminModelTxtBox.Text + "\n \n";
            txtGenerateReceipt.Text += "Quantity: " + AdminQuantityTxtBox.Text + "\n \n";
            txtGenerateReceipt.Text += "Price: " + AdminPriceTxtBox.Text + "\n \n";
            txtGenerateReceipt.Text += "Amount: " + AdminAmountTxtBox.Text + "\n \n";
           

            btnclearLmao();
          sql_con.Close();
        }


        private void Refreshdgv()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();

            string CommandText2 = "select * from Customer"; //select from table
            DB2 = new SQLiteDataAdapter(CommandText2, sql_con);
            DS2.Reset();
            DB2.Fill(DS2); //determine the data set
            DT2 = DS2.Tables[0]; //which row from db
            dgvCUSTOMERProfile.DataSource = DT2;

            string CommandText = "select * from Administrator"; //select from table
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS); //determine the data set
            DT = DS.Tables[0]; //which row from db
            dgvCusOrder.DataSource = DT;

            string CommandText1 = "select * from Accounts"; //select from table
            DB1 = new SQLiteDataAdapter(CommandText1, sql_con);
            DS1.Reset();
            DB1.Fill(DS1); //determine the data set
            DT1 = DS1.Tables[0]; //which row from db
            dgvMemberlist.DataSource = DT1;
            TXTHOST.DataSource = DT1;
            TXTHOST.DisplayMember = "Username";// can display any member u want
            TXTHOST.ValueMember = "Username";

            


            sql_con.Close();
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                   
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Refreshdgv();
            timer1.Stop();
        }

        private void btnClearAdmin_Click(object sender, EventArgs e)
        {
            txtOrderNum.Clear();
            TXTCusID.Clear();
            
            
            AdminProductTxtBox.Clear();
            AdminBrandTxtBox.Clear();
            AdminModelTxtBox.Clear();
            AdminQuantityTxtBox.Clear();
            AdminPriceTxtBox.Clear();
            AdminAmountTxtBox.Clear();
        }
        public void btnclearLmao()
        {
            txtOrderNum.Clear();
            TXTCusID.Clear();
            
          
            AdminProductTxtBox.Clear();
            AdminBrandTxtBox.Clear();
            AdminModelTxtBox.Clear();
            AdminQuantityTxtBox.Clear();
            AdminPriceTxtBox.Clear();
            AdminAmountTxtBox.Clear();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Administrator where Product = '" + AdminProductTxtBox.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
            // load data method
            string txtQuery1 = "delete from Customer where OrderNum = '" + txtOrderNum.Text + "'";
            ExecuteQuery(txtQuery1);
            LoadData();
            MessageBox.Show("all Product and customer information have been deleted.");
            btnclearLmao();
        }

        private void dgvCusOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminProductTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[1].Value.ToString();
            AdminBrandTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[2].Value.ToString();
            AdminModelTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[3].Value.ToString();
            AdminQuantityTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[4].Value.ToString();
            AdminPriceTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[5].Value.ToString();
            AdminAmountTxtBox.Text = dgvCusOrder.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dgvCUSTOMERProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderNum.Text = dgvCUSTOMERProfile.SelectedRows[0].Cells[1].Value.ToString();
            dtpadmin.Text = dgvCUSTOMERProfile.SelectedRows[0].Cells[2].Value.ToString();
            TXTCusID.Text = dgvCUSTOMERProfile.SelectedRows[0].Cells[3].Value.ToString();
            TXTCUSTOMER.Text = dgvCUSTOMERProfile.SelectedRows[0].Cells[4].Value.ToString();
            TXTHOST.Text = dgvCUSTOMERProfile.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            btnclearLmao();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtGenerateReceipt.Text, new Font("Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void AdminPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
          
            double num1;
            int num2;
            double res;
        
            
            if (txtChecker1.Text == "Member")
            {
                double.TryParse(AdminPriceTxtBox.Text.Trim(), out num1);
                int.TryParse(AdminQuantityTxtBox.Text.Trim(), out num2);
                res = num1 * num2;
                double Member_Bonus = res * 0.10;
                AdminAmountTxtBox.Text = Convert.ToString(Member_Bonus).ToString();
                
            }
            else
            {
                double.TryParse(AdminPriceTxtBox.Text.Trim(), out num1);

                int.TryParse(AdminQuantityTxtBox.Text.Trim(), out num2);
                res = num1 * num2;

                AdminAmountTxtBox.Text = Convert.ToString(res).ToString();
            }

        }

       
        private void TXTCUSTOMER_TextChanged_1(object sender, EventArgs e)
        {
            string query1 = "SELECT employeetype FROM Accounts WHERE Username=@name";
            string query2 = "SELECT ID FROM Accounts WHERE Username=@id";
            SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
            conn.Open();
            SQLiteCommand cmddd = new SQLiteCommand(query1, conn);
            SQLiteCommand cmdddd = new SQLiteCommand(query2, conn);
            cmddd.Parameters.AddWithValue("@name", TXTCUSTOMER.Text);
            cmdddd.Parameters.AddWithValue("@id", TXTCUSTOMER.Text);
            txtChecker1.Clear();


            SQLiteDataReader DR2 = cmdddd.ExecuteReader();
            SQLiteDataReader DR1 = cmddd.ExecuteReader();

            if (DR1.Read())
            {
                txtChecker1.Text = DR1.GetValue(0).ToString();
               
            }
            if (DR2.Read())
            {
                TXTCusID.Text = DR2.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void txtChecker1_TextChanged(object sender, EventArgs e)
        {
            txtPrompt.Visible = false;
            btnmembersignup.Visible = false;
            if (txtChecker1.Text == "Customer")
            {
                txtPrompt.Visible = true;
                btnmembersignup.Visible = true;
                txtConfirmationtxt.Visible = true;
            }
            
        }
        private void dgvMemberlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTCusID.Text = dgvMemberlist.SelectedRows[0].Cells[0].Value.ToString();
            TXTCUSTOMER.Text = dgvMemberlist.SelectedRows[0].Cells[1].Value.ToString();
            txtpassblank.Text = dgvMemberlist.SelectedRows[0].Cells[2].Value.ToString();
            txtmembership.Text = dgvMemberlist.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void btnmembersignup_Click(object sender, EventArgs e)
        {
            string txtQuery90 = "update Accounts set EmployeeType = '" + txtmembership.Text + "' where ID = '" + TXTCusID.Text + "'";
            ExecuteQuery(txtQuery90);
            LoadData(); // load data method
            MessageBox.Show("Membership information has been Updated.");
            sql_con.Close();
        }

        private void AdminAmountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
