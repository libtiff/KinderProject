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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }
        
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT ID,Firstname,Lastname,Birthday,Address,Nationality,HomeTelNum,MobileTelNum,AssignedClass,Salary,Sex,SocialInsNum,IDNum FROM dbo.DB_Employees";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridViewEmp.ReadOnly = true;
                    dataGridViewEmp.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmAddNewEmployee AddNewEmp = new FrmAddNewEmployee();
            AddNewEmp.setEditMode(false); //Declaring that this is an INSERT action and not an EDIT
            AddNewEmp.ShowDialog();
            updategrid();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string selectedvalue = dataGridViewEmp.SelectedCells[0].Value.ToString();
            General connstring = new General();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString()))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM dbo.DB_Employees WHERE ID=" + selectedvalue;
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {

            }
            updategrid();
            MessageBox.Show("Record Deleted.");
        }
        private void updategrid()
        {
            General connstring = new General();
            SqlConnection con = new SqlConnection(connstring.getconnectionString());
            SqlDataAdapter adapter;
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.DB_Employees", con);
            adapter.Fill(dt);
            dataGridViewEmp.DataSource = dt;
            con.Close();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            //Get the Selected Index Value
            string selectedvalue = dataGridViewEmp.SelectedCells[0].Value.ToString();
            General connstring = new General();
            if (int.Parse(selectedvalue.ToString()) == -1)
            {
                MessageBox.Show("No record was selected. Please select an employee to edit from below.");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString());
                string query = "SELECT * FROM dbo.DB_Employees WHERE ID=" + selectedvalue;
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                FrmAddNewEmployee UpdateEmp = new FrmAddNewEmployee();
                try
                {
                    sqlCon.Open();
                    using (SqlDataReader read = sqlCmd.ExecuteReader())
                    {
                        UpdateEmp.setEditMode(true);//We are setting the mode to true so we know we are editing the form and will load the values from FormLoad
                        while (read.Read())
                        {
                            string readFirstname = (read["Firstname"].ToString());
                            string readLastname = (read["Lastname"].ToString());
                            string readAddress = (read["Address"].ToString());
                            //string readBirthday = (read["Birthday"].ToString());
                            string readSex = (read["Sex"].ToString());
                            string readnationality = (read["Nationality"].ToString());
                            string readhometelnum = (read["HomeTelNum"].ToString());
                            string readmobiletelnum = (read["MobileTelNum"].ToString());
                            string readIDNum = (read["IDNum"].ToString());
                            string readsocialinsnum = (read["SocialInsNum"].ToString());
                            string readclass = (read["AssignedClass"].ToString());
                            string readSalary = (read["Salary"].ToString());
                            UpdateEmp.seteditID(int.Parse(selectedvalue));
                            UpdateEmp.setEditFirstname(readFirstname);
                            UpdateEmp.setEditLastname(readLastname);
                            UpdateEmp.setEditAddress(readAddress);
                            UpdateEmp.setEditSex(readSex);
                            //UpdateStudent.setEditBirthday(readBirthday);
                            UpdateEmp.setEditNationality(readnationality);
                            UpdateEmp.setEditHomeTelNum(readhometelnum);
                            UpdateEmp.setEditMobileTelNum(readmobiletelnum);
                            UpdateEmp.setEditSocialInsNum(readsocialinsnum);
                            UpdateEmp.setEditClass(readclass);
                            UpdateEmp.setEditIDNum(readIDNum);
                            UpdateEmp.setEditSalary(readSalary); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    //TODO:Catch Errors
                }
                finally
                {
                    sqlCon.Close();
                }
                
                //Open the AddNewStudentForm
                UpdateEmp.ShowDialog();
                updategrid();
            }
        }
    }
}
