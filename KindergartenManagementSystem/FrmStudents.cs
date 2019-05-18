using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace KindergartenManagementSystem
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
            this.DesktopLocation = new Point((Screen.PrimaryScreen.Bounds.Width / 2 - 420), 0);
        }

        int TogMove;
        int MValx;
        int MValy;
        string id;

        private void Paneltopcontrols_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValx = e.X;
            MValy = e.Y;
        }

        private void Paneltopcontrols_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Paneltopcontrols_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValx, MousePosition.Y - MValy);
            }
        }
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
            {
                using (conn)
                {
                    var select = "SELECT ID,FirstName,LastName,Birthday,Address,Nationality,MotherFullname,MotherTelNum,FatherFullname,FatherTelNum,HomeTelNum,Class,UsesLunch,UsesBus,Sex,MonthlyFee FROM dbo.DB_Students";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridStudents.ReadOnly = true;
                    dataGridStudents.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                //TODO:CATCH
            }
            conn.Close();
        }

        private void dataGridStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridStudents.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }
            
        
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
           string selectedvalue = dataGridStudents.SelectedCells[0].Value.ToString();
           string classvalue = dataGridStudents.SelectedCells[12].Value.ToString();
            General connstring = new General();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString()))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM dbo.DB_Students WHERE ID="+selectedvalue;
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {

            }
            capacitysubtract(classvalue);
            updateGrid();
            MessageBox.Show("Record Deleted.");
        }

        private void capacitysubtract(string value)
        {
                int capacitycounter = 0;
                General connstring = new General();
                SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString());
                string queryread = "SELECT RegisteredStudents FROM dbo.DB_Classes WHERE ClassName='" + value + "'";
                SqlCommand sqlCmd = new SqlCommand(queryread, sqlCon);
                //Get registered students value
                try
                {
                    sqlCon.Open();
                    using (SqlDataReader read = sqlCmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            capacitycounter = int.Parse(read["RegisteredStudents"].ToString());
                        }
                    sqlCon.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlCon.Close();
                    MessageBox.Show(ex.ToString(), "Exception Error");
                }
                //Subtract the registered students
                capacitycounter--;
                string updatequery = "UPDATE DB_Classes SET RegisteredStudents=" + capacitycounter + "WHERE ClassName='" + value + "'";
                sqlCmd = new SqlCommand(updatequery, sqlCon);
                try
                {
                 sqlCon.Open();
                 sqlCmd.ExecuteNonQuery();
                 sqlCon.Close();
                 }
                 catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString(), "Exception Error");
                   sqlCon.Close();
                }      
        }

        public void updateGrid()
        {
            General connstring = new General();
            SqlConnection con = new SqlConnection(connstring.getconnectionString());
            SqlDataAdapter adapter;
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.DB_Students", con);
            adapter.Fill(dt);
            dataGridStudents.DataSource = dt;
            con.Close();
        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = dataGridStudents.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddNewStudent AddNewStudent = new FrmAddNewStudent();
            AddNewStudent.setEditMode(false);
            AddNewStudent.ShowDialog();
            updateGrid();

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //Get the Selected Index Value
            string selectedvalue = dataGridStudents.SelectedCells[0].Value.ToString();

            if (int.Parse(selectedvalue.ToString()) == -1)
            {
                MessageBox.Show("No record was selected. Please select a student to edit from below.");
            }
            else
            {
                //ToDo: Add the below inside brackets
                General connstring = new General();
                SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString());
                string query = "SELECT * FROM dbo.DB_Students WHERE ID=" + selectedvalue;
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                FrmAddNewStudent UpdateStudent = new FrmAddNewStudent();

                try
                {
                    sqlCon.Open();
                    using (SqlDataReader read = sqlCmd.ExecuteReader())
                    {
                        UpdateStudent.setEditMode(true);//We are setting the mode to true so we know we are editing the form and will load the values from FormLoad
                        while (read.Read())
                        {
                            string readFirstname = (read["Firstname"].ToString());
                            string readLastname = (read["Lastname"].ToString());
                            string readAddress = (read["Address"].ToString());
                            //string readBirthday = (read["Birthday"].ToString());
                            string readSex = (read["Sex"].ToString());
                            string readnationality = (read["Nationality"].ToString());
                            string readmotherfullname = (read["MotherFullname"].ToString());
                            string readfatherfullname = (read["FatherFullname"].ToString());
                            string readmotherTelNum = (read["MotherTelNum"].ToString());
                            string readfatherTelNum = (read["FatherTelNum"].ToString());
                            string readhomeTelNum = (read["HomeTelNum"].ToString());
                            string readclass = (read["Class"].ToString());
                            bool readUsesBus = System.Convert.ToBoolean(read["UsesBus"]);
                            bool readUsesLunch = System.Convert.ToBoolean(read["UsesLunch"]);
                            UpdateStudent.setEditID(int.Parse(selectedvalue));
                            UpdateStudent.setEditFirstname(readFirstname);
                            UpdateStudent.setEditLastname(readLastname);
                            UpdateStudent.setEditAddress(readAddress);
                            UpdateStudent.setEditSex(readSex);
                            //UpdateStudent.setEditBirthday(readBirthday);
                            UpdateStudent.setEditNationality(readnationality);
                            UpdateStudent.setEditMothername(readmotherfullname);
                            UpdateStudent.setEditFathername(readfatherfullname);
                            UpdateStudent.setEditMotherTelNum(readmotherTelNum);
                            UpdateStudent.setEditFatherTelNum(readfatherTelNum);
                            UpdateStudent.setEditHomeTelNum(readhomeTelNum);
                            UpdateStudent.setEditClass(readclass);
                            UpdateStudent.setEditUsesBus(readUsesBus);
                            UpdateStudent.setEditUsesLunch(readUsesLunch);
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
                UpdateStudent.ShowDialog();
                updateGrid();

            }
        }
    }
}
