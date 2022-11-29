using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SANTOS_Prelim
{
    public partial class employeeRole : Form 
    {
        public employeeRole()
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
            sql_con = new SQLiteConnection("Data Source = MidtermDB.db;");   

            sql_con.Close();
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
            /*.DataSource = DT; //load table data*/



            sql_con.Close();

        }
        private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }



        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                modalEffect_Timer.Stop();

            }
            else
            {
                Opacity += .02;
            }
            int y = EmployeePortalForm.parentY += 3;
            this.Location = new Point(EmployeePortalForm.parentX + 220, y);
            if(y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void employeeRole_Load(object sender, EventArgs e)
        {
            i = EmployeePortalForm.parentY + 150;
            this.Location = new Point(EmployeePortalForm.parentX + 160, EmployeePortalForm.parentY + 150); //Change Location x and y axis here
            LoadData();
          
        }



        private void button1_Click(object sender, EventArgs e) //btn for Host that will open in new Window
        {
            var HostForm = new HostForm();
            if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "" /*&& (string)myValue == "empty Field"*/)
            {
                MessageBox.Show("Empty Fields");
                /*myValue = defaultValue;
                Microsoft.VisualBasic.Interaction.MsgBox("Error invalid Input = " + myValue.ToString(), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");*/
            }
            else
            {
                string query = "SELECT * FROM Accounts WHERE Username= @user";
                /*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*/

                sql_con.Open();
                /*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                   cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*/
                SQLiteCommand cmdd = new SQLiteCommand(query, sql_con);
                cmdd.Parameters.AddWithValue("@user", AdminChecker.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                sql_con.Close();
             
                if(dt.Rows.Count >= 0 && txtChecker.Text == "Administrator")
                {
                    /*hostForm.Show();*/
                    string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalHost.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    sql_con.Close();     
                    HostForm.Show();
                    /* Interaction.MsgBox("Hello, " + myValue.ToString() + "!" + Environment.NewLine + "nice Admin", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Works");   */
                    MessageBox.Show("Added account :>");
                    this.Close();
                    
                }
                else if (dt.Rows.Count > 0 && txtChecker.Text == "Host")
                {
                    MessageBox.Show("You aint paid for this");
                }
                else
                {
                    MessageBox.Show("wrong inputs");
                }

            }


            /*
             * 

                        string message, title, defaultValue;
                        object myValue;
                        message = "Input Username";
                        title = "Confirmation";
                        defaultValue = "Empty Field";*/

    /*        string query = "SELECT * FROM Accounts WHERE Username= @user";
            *//*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*//*

            sql_con.Open();
             *//*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*//*
            SQLiteCommand cmdd = new SQLiteCommand(query, sql_con);
            cmdd.Parameters.AddWithValue("@user", AdminChecker.Text);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        
            sql_con.Close();*/
/*            var HostForm = new HostForm();
            //display message
            *//* myValue = Interaction.InputBox(message, title, defaultValue);*//*
            // if user clicked cancel, set my value to default value
            *//*HostForm hostForm = new HostForm();*//*
            if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "" *//*&& (string)myValue == "empty Field"*//*)
            {
                MessageBox.Show("Empty Fields");
                *//*myValue = defaultValue;
                Microsoft.VisualBasic.Interaction.MsgBox("Error invalid Input = " + myValue.ToString(), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");*//*
            }     
            else if (dt.Rows.Count > 0 && txtChecker.Text == "Administrator")
            {
                *//*hostForm.Show();*//*
                string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalHost.Text + "')";
                ExecuteQuery(txtQuery);
                LoadData();


                HostForm.Show();
                *//* Interaction.MsgBox("Hello, " + myValue.ToString() + "!" + Environment.NewLine + "nice Admin", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Works");   *//*
                MessageBox.Show("Added account :>");
                this.Close();
               
            }
            else if (dt.Rows.Count > 0 && txtChecker.Text == "Host")
            {
                MessageBox.Show("You aint paid for this");
            }
            else
            {
                MessageBox.Show("wrong inputs");
            }
*/
            
            /* else
             {
                 //Added values 
                 string txtQuery = "insert into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalHost.Text + "')";
                 ExecuteQuery(txtQuery);
                 LoadData();
                 MessageBox.Show("Added");
                 var HostForm = new HostForm();
                 HostForm.Show(); // change later for other functions
                 this.Close();
                 Interaction.MsgBox("Hello, " + myValue.ToString() + "!" + Environment.NewLine + "nice Admin", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Works");
             }*/


            /*  if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "")
              {
                  MessageBox.Show("Invalid Input, Empty Fields");
              }
              else
              {
                  string txtQuery = "insert into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalHost.Text + "')";
                  ExecuteQuery(txtQuery);
                  LoadData();
                  MessageBox.Show("Added");
                  var HostForm = new HostForm();
                  HostForm.Show(); // change later for other functions
                  this.Close();
              }*/
        }
   

        private void btnPortalAdmin_Click(object sender, EventArgs e)
        {
            var AdministrationFOrm = new AdministratorForm();
            if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "" /*&& (string)myValue == "empty Field"*/)
            {
                MessageBox.Show("Empty Fields");
                /*myValue = defaultValue;
                Microsoft.VisualBasic.Interaction.MsgBox("Error invalid Input = " + myValue.ToString(), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");*/
            }
            else
            {
                string query = "SELECT * FROM Accounts WHERE Username= @user";
                /*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*/

                sql_con.Open();
                /*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                   cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*/
                SQLiteCommand cmdd = new SQLiteCommand(query, sql_con);
                cmdd.Parameters.AddWithValue("@user", AdminChecker.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                sql_con.Close();
                
                if (dt.Rows.Count >= 0 && txtChecker.Text == "Administrator")
                {
                    /*hostForm.Show();*/
                    string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalAdmin.Text + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    sql_con.Close();
                    AdministrationFOrm.Show();
                    /* Interaction.MsgBox("Hello, " + myValue.ToString() + "!" + Environment.NewLine + "nice Admin", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Works");   */
                    MessageBox.Show("Added account :>");
                    this.Close();
                    
                }
                else if (dt.Rows.Count > 0 && txtChecker.Text == "Host")
                {
                    MessageBox.Show("You aint paid for this");
                }
                else
                {
                    MessageBox.Show("wrong inputs");
                }

            }

            /*      string query = "SELECT * FROM Accounts WHERE Username= @user";
                  *//*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*//*

                  sql_con.Open();
                  *//*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                     cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*//*
                  SQLiteCommand cmdd = new SQLiteCommand(query, sql_con);
                  cmdd.Parameters.AddWithValue("@user", AdminChecker.Text);
                  SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                  DataTable dt = new DataTable();
                  da.Fill(dt);

                  sql_con.Close();
                  var Admminformpage = new AdministratorForm();
                  //display message
                  *//* myValue = Interaction.InputBox(message, title, defaultValue);*//*
                  // if user clicked cancel, set my value to default value
                  *//*HostForm hostForm = new HostForm();*//*
                  if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "" *//*&& (string)myValue == "empty Field"*//*)
                  {
                      MessageBox.Show("Empty Fields");
                      *//*myValue = defaultValue;
                      Microsoft.VisualBasic.Interaction.MsgBox("Error invalid Input = " + myValue.ToString(), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");*//*
                  }
                  else if (dt.Rows.Count > 0 && txtChecker.Text == "Administrator")
                  {
                      Admminformpage.Show();
                      *//*hostForm.Show();*//*
                      string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalAdmin.Text+ "')";
                      ExecuteQuery1(txtQuery);
                      LoadData();


                      *//* Interaction.MsgBox("Hello, " + myValue.ToString() + "!" + Environment.NewLine + "nice Admin", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Works");   *//*
                      MessageBox.Show("Added account :>");
                      this.Close();

                  }
                  else if (dt.Rows.Count > 0 && txtChecker.Text == "Host")
                  {
                      MessageBox.Show("You aint paid for this");
                  }
                  else
                  {
                      MessageBox.Show("wrong inputs");
                  }

      */
            /*  string query1 = "SELECT employeetype FROM Accounts WHERE Username=@name";
              SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
              conn.Open();
              SQLiteCommand cmddd = new SQLiteCommand(query1, conn);
              cmddd.Parameters.AddWithValue("@name", TXTempName.Text);

              SQLiteDataAdapter daa = new SQLiteDataAdapter(cmddd);
              DataTable dtt = new DataTable();
              SQLiteDataReader DR1 = cmddd.ExecuteReader();

              if (DR1.Read())
              {
                  txtChecker.Text = DR1.GetValue(0).ToString();
              }
              conn.Close();*/
            /*
                        string message, title, defaultValue;
                        object myValue;
                        message = "Input Username";
                        title = "Confirmation";
                        defaultValue = "Empty Field";*/





            /*
                        string query = "SELECT * FROM Accounts WHERE Username= @user";
                        *//*string query1 = "SELECT * FROM Accounts WHERE EmployeeType= @employeet";*//*
                        SQLiteConnection connn = new SQLiteConnection("Data Source=MidtermDB.db");
                        connn.Open();
                        *//*   SQLiteCommand cmddD = new SQLiteCommand(query1, conn);
                           cmddD.Parameters.AddWithValue("@employeet", TXTWElcomEployeeType.Text);*//*
                        SQLiteCommand cmdd = new SQLiteCommand(query, connn);
                        cmdd.Parameters.AddWithValue("@user", AdminChecker.Text);

                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        connn.Close();

                        //display message

                        // if user clicked cancel, set my value to default value
                        AdministratorForm administratorForm = new AdministratorForm();
                        if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "") 
                        {
                            MessageBox.Show("Invalid Inputs");
                        }
                        else if (dt.Rows.Count > 0 && txtChecker.Text == "Administrator")
                        {
                           *//* AdministratorForm adminForm = new AdministratorForm();
                            adminForm.Show();*//*
                            string txtQuery1 = "insert into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalAdmin.Text + "')";
                            ExecuteQuery1(txtQuery1);
                            LoadData();
                            MessageBox.Show("Added account :> ");

                            administratorForm.Show();


                            this.Close();
                        }
                        else if (dt.Rows.Count > 0 && txtChecker.Text == "Host")
                        {
                            MessageBox.Show("You aint paid for this");
                        }
                        */

            /* if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "")
             {
                 MessageBox.Show("Invalid Input, Empty Fields");
             }

             else
             {
                 string txtQuery = "insert into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnPortalAdmin.Text + "')";
                 ExecuteQuery(txtQuery);
                 LoadData();
                 MessageBox.Show("Added");
                 var AdminForm = new AdministratorForm();
                 AdminForm.Show();
                 this.Close();
             }*/

        }



       /* private void TXTempPass_TextChanged(object sender, EventArgs e)
        {
            string query1 = "SELECT employeetype FROM Accounts WHERE Username=@name";
            *//*  SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
              conn.Open();*//*
            sql_con.Open();
            SQLiteCommand cmddd = new SQLiteCommand(query1, sql_con);
            cmddd.Parameters.AddWithValue("@name", AdminChecker.Text);

            SQLiteDataAdapter daa = new SQLiteDataAdapter(cmddd);
            DataTable dtt = new DataTable();

            SQLiteDataReader DR1 = cmddd.ExecuteReader();

            if (DR1.Read())
            {
                txtChecker.Text = DR1.GetValue(0).ToString();
            }
            sql_con.Close();
        }

        private void btnaddCustomer_Click(object sender, EventArgs e)
        {

            string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnaddCustomer.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Added Customer account :>");
            
        }*/

        private void TXTempPass_TextChanged_1(object sender, EventArgs e)
        {
            string query1 = "SELECT employeetype FROM Accounts WHERE Username=@name";
            /*  SQLiteConnection conn = new SQLiteConnection("Data Source=MidtermDB.db");
              conn.Open();*/
            sql_con.Open();
            SQLiteCommand cmddd = new SQLiteCommand(query1, sql_con);
            cmddd.Parameters.AddWithValue("@name", AdminChecker.Text);

            SQLiteDataAdapter daa = new SQLiteDataAdapter(cmddd);
            DataTable dtt = new DataTable();

            SQLiteDataReader DR1 = cmddd.ExecuteReader();

            if (DR1.Read())
            {
                txtChecker.Text = DR1.GetValue(0).ToString();
            }
            sql_con.Close();
        }

        private void btnaddCustomer_Click_1(object sender, EventArgs e)
        {
            if (TXTempName.Text.Trim() == "" && TXTempPass.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Input, Empty Fields");
            }
            else
            {
                string txtQuery = "INSERT into Accounts(Username,Password,EmployeeType) values ('" + TXTempName.Text + "', '" + TXTempPass.Text + "','" + btnaddCustomer.Text + "')";
                ExecuteQuery(txtQuery);
                LoadData();
                MessageBox.Show("Added Customer account :>");
                sql_con.Close();
            }
       
        }
    }
}
