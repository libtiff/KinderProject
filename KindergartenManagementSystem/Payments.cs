using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenManagementSystem
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        //Xristos Vasiliou
        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_KindergartenDataSet1.DB_Months' table. You can move, or remove it, as needed.
            this.dB_MonthsTableAdapter.Fill(this.dB_KindergartenDataSet1.DB_Months);
            // TODO: This line of code loads data into the 'dB_KindergartenDataSet.DB_Years' table. You can move, or remove it, as needed.
            this.dB_YearsTableAdapter.Fill(this.dB_KindergartenDataSet.DB_Years);
        }

        private void getunpaidstuds()
        {
            string yID = cmbyears.SelectedValue.ToString(); //Get Selected Year
            string mID = cmbmonths.SelectedValue.ToString(); //Get Selected Month
            
            string select = "SELECT DB_Students.Firstname,DB_Students.Lastname,DB_Students.MonthlyFee FROM DB_Students left outer JOIN DB_" + mID + " ON DB_" + mID + ".StudentID = DB_Students.ID or DB_" + mID + ".YearID <> '"+yID+"' where DB_"+mID+".StudentID is null";
            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
            {
                using (conn)
                {
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds1 = new DataSet();
                    dataAdapter.Fill(ds1);
                    dataGridunpaid.ReadOnly = true;
                    dataGridunpaid.DataSource = ds1.Tables[0];
                    dataGridunpaid.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void getpaidstuds()
        {
            string yID = cmbyears.SelectedValue.ToString(); //Get Selected Year
            string mID = cmbmonths.SelectedValue.ToString(); //Get Selected Month

            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT Studentname,StudentLastname FROM dbo.DB_"+ mID + " WHERE YearID="+yID;

                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridpaid.ReadOnly = true;
                    dataGridpaid.DataSource = ds.Tables[0];
                    dataGridpaid.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void loadstuds()
        {
            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
            {
                using (conn)
                {
                    conn.Open();
                    var select = "SELECT ID ,Firstname,Lastname,MonthlyFee FROM dbo.DB_Students";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridallstuds.ReadOnly = true;
                    dataGridallstuds.DataSource = ds.Tables[0];
                    dataGridallstuds.Update();
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            loadstuds();
            getpaidstuds();
            getunpaidstuds();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            string selectedvalue = dataGridallstuds.SelectedCells[0].Value.ToString();
            MessageBox.Show(selectedvalue);

            General connstring = new General();
            string yID = cmbyears.SelectedValue.ToString();
            string mID = cmbmonths.SelectedValue.ToString();
            string studname = dataGridallstuds.SelectedCells[1].Value.ToString();
            string studlastname = dataGridallstuds.SelectedCells[2].Value.ToString();
           
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString()))
                {
                    sqlCon.Open();
                    string query = "INSERT INTO dbo.DB_"+mID + " (Studentname,StudentLastname,StudentID,YearID) VALUES (@Studentname,@StudentLastname,@StudentID,@YearID)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@Studentname", studname);
                    sqlCmd.Parameters.AddWithValue("@StudentLastname", studlastname);
                    sqlCmd.Parameters.AddWithValue("@StudentID", selectedvalue);
                    sqlCmd.Parameters.AddWithValue("@YearID", yID);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
