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

namespace KindergartenManagementSystem
{
    public partial class FrmAddNewStudent : Form
    {

        public FrmAddNewStudent()
        {
            InitializeComponent();
        }

        private int lunch = 0;
        private int bus = 0;
        private int cost = 0;

        private bool editMode; //If this is true we are using the form to UPDATE , if its false we are INSERTING
        private string editFirstname;
        private string editLastname;
        private string editBirthday;
        private string editNationality;
        private string editAddress;
        private string editSex;
        private string editMotherName;
        private string editFatherName;
        private string editMotherTelNum;
        private string editFatherTelNum;
        private string editHomeTelNum;
        private string editClass;
        private bool editUsesBus;
        private bool editUsesLunch;
        private int EditID;

        public void setEditMode(bool value)
        {
            editMode = value;
        }
        public void setEditID(int value)
        {
           EditID = value;
        }
        public void setEditFirstname(string value)
        {
            editFirstname = value;
        }
        public void setEditLastname(string value)
        {
            editLastname = value;
        }
        public void setEditBirthday(string value)
        {
            editBirthday = value;
        }
        public void setEditNationality(string value)
        {
            editNationality = value;
        }
        public void setEditAddress(string value)
        {
            editAddress = value;
        }
        public void setEditSex(string value)
        {
            editSex = value;
        }
        public void setEditMothername(string value)
        {
            editMotherName = value;
        }
        public void setEditFathername(string value)
        {
            editFatherName = value;
        }
        public void setEditMotherTelNum(string value)
        {
            editMotherTelNum = value;
        }
        public void setEditFatherTelNum(string value)
        {
            editFatherTelNum = value;
        }
        public void setEditHomeTelNum(string value)
        {
            editHomeTelNum= value;
        }
        public void setEditUsesBus(bool value)
        {
            editUsesBus = value;
        }
        public void setEditUsesLunch(bool value)
        {
            editUsesLunch = value;
        }
        public void setEditClass(string value)
        {
            editClass = value;
        }
        string querycmd;


        private void FrmAddNewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_KindergartenDataClasses.DB_Classes' table. You can move, or remove it, as needed.
            this.dB_ClassesTableAdapter.Fill(this.dB_KindergartenDataClasses.DB_Classes);
            cmbboxclass.SelectedValue = "";

            if (editMode == true)//This means we are using the form to edit and we get 
            {
                txtboxfirstname.Text = editFirstname;
                txtboxlastname.Text = editLastname;
                cmbboxsex.SelectedItem = editSex;
                txtboxaddress.Text = editAddress;
                //dateTimePicker1.Value = editBirthday;
                txtboxnationality.Text = editNationality;
                txtboxmothername.Text = editMotherName;
                txtboxfathername.Text = editFatherName;
                txtboxmothertelnum.Text = editMotherTelNum;
                txtboxfathertelnum.Text = editFatherTelNum;
                txtboxhometelnum.Text = editHomeTelNum;
                cmbboxclass.SelectedValue = editClass;
                switch (editUsesBus)
                {
                    case true:
                        {
                           chkboxbus.Checked = true;
                           break;
                        }
                        case false:
                        {
                           chkboxbus.Checked = false;
                           break;
                        }
                }
                switch (editUsesLunch)
                {
                    case true:
                        {
                            chkboxlunch.Checked = true;
                            break;
                        }
                    case false:
                        {
                            chkboxlunch.Checked = false;
                            break;
                        }
                }
                querycmd = "UPDATE DB_Students SET FirstName=@Firstname,LastName=@Lastname,Birthday=@Birthday,Address=@Address,Nationality=@Nationality,MotherFullname=@MotherFullname,MotherTelNum=@MotherTelNum,FatherFullname=@FatherFullname,FatherTelNum=@FatherTelNum,HomeTelNum=@HomeTelNum,Class=@Class,UsesLunch=@UsesLunch,UsesBus=@UsesBus,Sex=@Sex,MonthlyFee=@MonthlyFee WHERE ID=" + EditID;
            }
        }

        public void classcapacity()
        {
            int capacitycounter=0;
            int MaxCapacity=0;
            General connstring = new General();
            string connectionString = connstring.getconnectionString(); //get string from the form Students
            SqlConnection sqlCon = new SqlConnection(connectionString);
            string queryread = "SELECT RegisteredStudents,MaxCapacity FROM dbo.DB_Classes WHERE ClassName='"+ cmbboxclass.SelectedValue + "'";
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
                        MaxCapacity = int.Parse((read["MaxCapacity"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception Error");
            }
            finally
            {
                if (capacitycounter == MaxCapacity)
                {
                    sqlCon.Close();
                    MessageBox.Show("Class is full , you cannot register any more students!", "Exception Error");
                }
                else
                {
                    sqlCon.Close();
                    //If Succeded add new student to counter
                    capacitycounter++;
                    string updatequery = "UPDATE DB_Classes SET RegisteredStudents=" + capacitycounter + "WHERE ClassName='" + cmbboxclass.SelectedValue + "'";
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
                    }
                    sqlCon.Close();
                }
            }     
        }

        private int feecalculation(int cost , int bus , int lunch)
        {
                int totalcost=0;
                totalcost = cost + bus + lunch;
                return totalcost;
        }

        private void cmbboxclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbboxclass.SelectedValue)
            {
                case "Infants":
                    {
                        cost = 450;
                        break;
                    }
                case "Pre-Toddlers":
                    {
                        cost = 350;
                        break;
                    }
                case "Toddlers":
                    {
                        cost = 250;
                        break;
                    }
                case null:
                    {
                        cost = 0;
                        break;
                    }
                default: break;
            }
            txtboxtotalcost.Text = feecalculation(cost, bus, lunch).ToString();
        }

        private void chkboxlunch_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkboxlunch.Checked)
            {
                    case true:
                    {
                        lunch = 150;
                        break;
                    }
                case false:
                    {
                        lunch = 0;
                        break;
                    }     
            }
            txtboxtotalcost.Text = feecalculation(cost, bus, lunch).ToString();
        }

        private void chkboxbus_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkboxbus.Checked)
            {
                case true:
                    {
                        bus = 150;
                        break;
                    }
                case false:
                    {
                        bus = 0;
                        break;
                    }
            }
            txtboxtotalcost.Text = feecalculation(cost, bus, lunch).ToString();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            General connstring = new General();
            string connectionString = connstring.getconnectionString(); //get string from the form Students
            lblerror.Text = "";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = null ;

                    if (editMode==true)
                    {
                        query = querycmd;
                    }
                    else if (editMode == false)
                    {
                        query = "INSERT INTO DB_Students (FirstName,LastName,Birthday,Address,Nationality,MotherFullname,MotherTelNum,FatherFullname,FatherTelNum,HomeTelNum,Class,UsesLunch,UsesBus,Sex,MonthlyFee) VALUES (@Firstname,@Lastname,@Birthday,@Address,@Nationality,@MotherFullname,@MotherTelNum,@FatherFullname,@FatherTelNum,@HomeTelNum,@Class,@UsesLunch,@UsesBus,@Sex,@MonthlyFee)";
                    }
                     SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                    //ValidatorsChecks For NULL
                    //FirstName
                    if (txtboxfirstname.Text.Trim() == "" || txtboxfirstname.Text == null)
                    {
                        lblerror.Text = "Field Firstname cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Firstname", txtboxfirstname.Text.Trim());
                    }
                    //LastName
                    if (txtboxlastname.Text.Trim() == "" || txtboxlastname.Text == null)
                    {
                        lblerror.Text = "Field Lastname cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Lastname", txtboxlastname.Text.Trim());
                    }
                    //Birthday
                    if (dateTimePicker1.Value == null)
                    {
                        lblerror.Text = "Field Birthday cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Birthday",dateTimePicker1.Value);
                    }
                    //Address
                    if (txtboxaddress.Text.Trim() == ""|| txtboxaddress.Text == null)
                    {
                        lblerror.Text = "Field Address cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Address", txtboxaddress.Text.Trim());
                    }
                    //Nationality
                    if (txtboxnationality.Text.Trim() == "" || txtboxnationality.Text == null)
                    {
                        lblerror.Text = "Field Nationality cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Nationality", txtboxnationality.Text.Trim());
                    }
                    //MotherName
                    if (txtboxmothername.Text.Trim() == "" || txtboxmothername.Text == null)
                    {
                        lblerror.Text = "Field Mother Name cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Motherfullname", txtboxmothername.Text.Trim());
                    }
                    //MotherTelNum
                    if (txtboxmothertelnum.Text.Trim() == "" || txtboxmothertelnum.Text == null)
                    {
                        lblerror.Text = "Field Mother telephone cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Mothertelnum", txtboxmothertelnum.Text.Trim());
                    }
                    //FatherName
                    if (txtboxfathername.Text.Trim() == "" || txtboxfathername.Text == null)
                    {
                        lblerror.Text = "Field Father Name cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Fatherfullname", txtboxfathername.Text.Trim());   
                    }
                    //FatherTelNum
                    if (txtboxfathertelnum.Text.Trim() == "" || txtboxfathertelnum.Text == null)
                    {
                        lblerror.Text = "Field Father Telephone cannot be empty";   
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@FatherTelNum", txtboxfathertelnum.Text.Trim());
                    }
                    //HomeTel
                    if (txtboxhometelnum.Text.Trim() == "" || txtboxhometelnum.Text == null)
                    {
                        lblerror.Text = "Field HomeTelephone cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Hometelnum", txtboxhometelnum.Text.Trim());
                    }
                    //Class
                    if (cmbboxclass.SelectedItem == null)
                    {
                        lblerror.Text = "Class cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Class", cmbboxclass.SelectedValue);
                    }
                    //Uses Lunch
                    if (chkboxlunch.Checked == true)
                    {
                        sqlCmd.Parameters.AddWithValue("@UsesLunch", true);
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@UsesLunch", false);
                    }
                    //Uses Bus
                    if (chkboxbus.Checked == true)
                    {
                        sqlCmd.Parameters.AddWithValue("@UsesBus", true);
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@UsesBus", false);
                    }
                    //Sex
                    if (cmbboxsex.SelectedItem == null)
                    {
                        lblerror.Text = "Sex cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Sex", cmbboxsex.SelectedItem);
                    }
                    //If there are no errors
                    if (lblerror.Text == "")
                    {
                        sqlCmd.Parameters.AddWithValue("@MonthlyFee", txtboxtotalcost.Text);
                        sqlCmd.ExecuteNonQuery();
                        lblerror.ForeColor = System.Drawing.Color.Green;
                        if (editMode==true)//Specific actions to EDIT MODE
                        {
                            lblerror.Text = "Record Succesfully Edited.";
                        }
                        else //Specific actions for INSERT MODE
                        {
                            lblerror.Text = "New Record Added.";
                            classcapacity();//Update Class record
                        }
                        //TODO CHECK IF SUCCESS
                        this.Close();
                        editMode = false; //SetMode back to false
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Exception Error");
               lblerror.Text = ex.ToString();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = Convert.ToString(dateTimePicker1.Value);
        }
    }
}
