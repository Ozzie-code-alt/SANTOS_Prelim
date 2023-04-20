using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANTOS_Prelim
{
    public partial class EmployeePortalForm : Form
    {
     
        public EmployeePortalForm()
        {
            InitializeComponent();
        }

        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataAdapter DB;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        private void setConnection()
        {
            sql_con = new SQLiteConnection("Data Source = MidtermDB.db;Version=3;Synchronous=Full;");

        }
        private void LoadData()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Accounts"; //select from table
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS); //determine the data set
            DT = DS.Tables[0]; //which row from db
            /*dgvAdmin.DataSource = DT; //load table data*/
            sql_con.Close();

        }
 /*       private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }*/
        public static int parentX, parentY;

        int[] targetColor = { 0, 0, 0 };
        int[] fadeRGB = new int[3];
        private void timer1_Tick(object sender, EventArgs e)
        {
        
            fadeIn();
            
        }
        void fadeOut()
        {
            fadeRGB[0] = lblWelcome.ForeColor.R;
            fadeRGB[1] = lblWelcome.ForeColor.G;
            fadeRGB[2] = lblWelcome.ForeColor.B;

            if (fadeRGB[0] > this.BackColor.R)
            {
                fadeRGB[0]--;
            }
            else if (fadeRGB[0] < this.BackColor.R)
            {
                fadeRGB[0]++;
            }
            if (fadeRGB[1] > this.BackColor.G)
            {
                fadeRGB[1]--;
            }
            else if (fadeRGB[1] < this.BackColor.G)
            {
                fadeRGB[1]++;
            }
            if (fadeRGB[2] > this.BackColor.B)
            {
                fadeRGB[2]--;
            }
            else if (fadeRGB[2] < this.BackColor.B)
            {
                fadeRGB[2]++;
            }
            if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
            {
                timer1.Stop();
            }
            lblWelcome.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            welcomBTN.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
           
        }
        void fadeIn()
        {
            fadeRGB[0] = lblWelcome.ForeColor.R;
            fadeRGB[1] = lblWelcome.ForeColor.G;
            fadeRGB[2] = lblWelcome.ForeColor.B;

            if (fadeRGB[0] > targetColor[0])
            {
                fadeRGB[0]--;
            }
            else if (fadeRGB[0] < targetColor[0])
            {
                fadeRGB[0]++;
            }
            if (fadeRGB[1] > targetColor[1])
            {
                fadeRGB[1]--;
            }
            else if (fadeRGB[1] < targetColor[1])
            {
                fadeRGB[1]++;
            }
            if (fadeRGB[2] > targetColor[2])
            {
                fadeRGB[2]--;
            }
            else if (fadeRGB[2] < targetColor[2])
            {
                fadeRGB[2]++;
            }
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
            {
                timer1.Stop();
            }
            lblWelcome.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            welcomBTN.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            WelcomtxtUsername.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            WElcomeTxtPass.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            label2.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            label3.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            BtnWelcomeLogin.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            TXTWElcomEployeeType.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            label4.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        private void EmployeePortalForm_Load(object sender, EventArgs e)
        {
            lblWelcome.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            LoadData();
        }








        private void BtnWelcomeLogin_Click(object sender, EventArgs e)
        {
           
            if(WelcomtxtUsername.Text.Trim()=="" && WElcomeTxtPass.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Input, Empty Fields");
            }
            else
            {
                string query = "SELECT * FROM Accounts WHERE Username= @user AND Password= @pass";
                /*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*/
                SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
                conn.Open();
             /*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*/
                SQLiteCommand cmdd = new SQLiteCommand(query, conn);
                cmdd.Parameters.AddWithValue("@user", WelcomtxtUsername.Text);
                cmdd.Parameters.AddWithValue("@pass", WElcomeTxtPass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                DataTable dt = new DataTable();
                conn.Close();
                da.Fill(dt);

                {

                }
                if (dt.Rows.Count > 0 && TXTWElcomEployeeType.Text == "Host") // fix and get back to this 
                {
                    EmployeePortalForm employeePortalForm = new EmployeePortalForm();
                    employeePortalForm.Close();
                    HostForm hostForm = new HostForm();
                    hostForm.Show();
                 
                }
                else if (dt.Rows.Count > 0 && TXTWElcomEployeeType.Text == "Administrator")
                {
                    EmployeePortalForm employeePortalForm = new EmployeePortalForm();
                    employeePortalForm.Close();
                    AdministratorForm adminForm = new AdministratorForm();
                    adminForm.Show();
                   

                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                
            }
           
        }



        private void WElcomeTxtPass_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT employeetype FROM Accounts WHERE Username=@name";
            SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
            conn.Open();
            SQLiteCommand cmddd = new SQLiteCommand(query, conn);
            cmddd.Parameters.AddWithValue("@name", WelcomtxtUsername.Text);
            
            SQLiteDataAdapter daa = new SQLiteDataAdapter(cmddd);
            DataTable dtt = new DataTable();
            SQLiteDataReader DR1 = cmddd.ExecuteReader();

            if (DR1.Read())
            {
                TXTWElcomEployeeType.Text = DR1.GetValue(0).ToString();
            }
            conn.Close();

            /*    SQLiteConnection conn1 = new SQLiteConnection("Data Source=MidtermDB.db");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select EmployeeType from Accounts where Username= @user");
                cmd1.Parameters.AddWithValue("user", WelcomtxtUsername.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    TXTWElcomEployeeType.Text = reader1["EmployeeType"].ToString();
                }
                else
                {
                    MessageBox.Show("No data Found");
                }
                conn1.Close();*/
            /*  string query1 = "SELECT * EmployeeType FROM Accounts WHERE Username= @user";
              SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
              conn.Open();
              SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
              cmddD.Parameters.AddWithValue("@user", WelcomtxtUsername.Text);*/
        }

        private void TXTWElcomEployeeType_TextChanged(object sender, EventArgs e)
        {

        }



        /* private void btnWelcomeCheck_Click(object sender, EventArgs e)
         {
             string query = "SELECT employeetype FROM Accounts WHERE Username=@name";
             SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
             conn.Open();
             SQLiteCommand cmddd = new SQLiteCommand(query, conn);
             cmddd.Parameters.AddWithValue("@name", WelcomtxtUsername.Text);
             cmddd.Parameters.AddWithValue("@id", TXTwelcomID.Text);
             SQLiteDataAdapter daa = new SQLiteDataAdapter(cmddd);
             DataTable dtt = new DataTable();
             SQLiteDataReader DR1 = cmddd.ExecuteReader();

             if (DR1.Read())
             {
                 TXTWElcomEployeeType.Text = DR1.GetValue(0).ToString();
             }
             conn.Close();
     *//*        try
             {
                 cmd.CommandText = "UPDATE Accounts Set EmployeeType=@empt where Username =@name";
                 cmd.Prepare();
                 cmd.Parameters.AddWithValue("@name", WelcomtxtUsername.Text);
                 cmd.Parameters.AddWithValue("@empt", TXTWElcomEployeeType.Text);
                 cmd.ExecuteNonQuery();
             }
             catch (Exception)
             {
                 Console.WriteLine("Cannot update");
                 return;
             }*/


        /* SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
         conn.Open();
         string query = "SELECT * FROM Accounts";
         SQLiteCommand myCommand = new SQLiteCommand(query, conn);
         myCommand.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);


         conn.Close();*//*

    }*/

        private void welcomBTN_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (employeeRole modal = new employeeRole())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
    }
}
