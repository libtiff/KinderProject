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
    public partial class FrmClasses : Form
    {
        public FrmClasses()
        {
            InitializeComponent();
        }

        private void FrmClasses_Load(object sender, EventArgs e)
        {
            //this.dB_ClassesTableAdapter.Fill(this.dB_Classes._DB_Classes);
            General connstring = new General();
            string connectionString = connstring.getconnectionString();

          
            getTotalClasses(connectionString);
            getInfants(connectionString);
            getPreToddlers(connectionString);
            getToddlers(connectionString);
        }

        private void getTotalClasses(string connectionString)
        {
            var conn = new SqlConnection(connectionString); // Your Connection String here
            try
            {
                using (conn)
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "SELECT * FROM dbo.DB_Classes";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridClasses.DataSource = dtRecord;
                }
            }
            catch
            {

            }
            conn.Close();
        }

        private void getInfants(string connectionString)
        {
            var conn = new SqlConnection(connectionString); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT Firstname,Lastname,Class FROM dbo.DB_Students WHERE Class='Infants'";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridViewInfants.ReadOnly = true;
                    dataGridViewInfants.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

        private void getPreToddlers(string connectionString)
        {
            var conn = new SqlConnection(connectionString); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT Firstname,Lastname,Class FROM dbo.DB_Students WHERE Class='Pre-Toddlers'";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridViewPreToddlers.ReadOnly = true;
                   dataGridViewPreToddlers.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

        private void getToddlers(string connectionString)
        {
            var conn = new SqlConnection(connectionString); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT Firstname,Lastname,Class FROM dbo.DB_Students WHERE Class='Toddlers'";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridViewToddlers.ReadOnly = true;
                    dataGridViewToddlers.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

    }
}
