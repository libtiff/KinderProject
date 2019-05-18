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
    public partial class FrmAddNewEmployee : Form
    {
        public FrmAddNewEmployee()
        {
            InitializeComponent();
        }

        private bool editMode;
        private int editID;
        private string editFirstname;
        private string editLastname;
        private string editBirthday;
        private string editNationality;
        private string editAddress;
        private string editSex;
        private string editHomeTelNum;
        private string editMobileTelNum;
        private string editSocialInsNum;
        private string editIDNum;
        private string editSalary;
        private string editClass;

        public void seteditID(int value)
        {
            editID = value;
        }
        public void setEditMode(bool value)
        {
            editMode = value;
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
        public void setEditHomeTelNum(string value)
        {
            editHomeTelNum = value;
        }
        public void setEditMobileTelNum(string value)
        {
            editMobileTelNum = value;
        }
        public void setEditSocialInsNum(string value)
        {
            editSocialInsNum = value;
        }
        public void setEditSalary(string value)
        {
            editSalary = value;
        }
        public void setEditIDNum(string value)
        {
            editIDNum = value;
        }
        public void setEditClass(string value)
        {
            editClass = value;
        }

        private void FrmAddNewEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_KindergartenDataClasses.DB_Classes' table. You can move, or remove it, as needed.
            this.dB_ClassesTableAdapter.Fill(this.dB_KindergartenDataClasses.DB_Classes);

            if (editMode == true)//This means we are using the form to edit and we get 
            {
                txtboxfirstname.Text = editFirstname;
                txtboxlastname.Text = editLastname;
                cmbboxsex.SelectedItem = editSex;
                txtboxaddress.Text = editAddress;
                //dateTimePicker1.Value = editBirthday;
                txtboxnationality.Text = editNationality;
                txtboxid.Text = editIDNum;
                txtboxsocialins.Text = editSocialInsNum;
                txtboxhomenum.Text = editHomeTelNum;
                txtboxmobilenum.Text = editMobileTelNum;
                txtboxsalary.Text = editSalary;
                cmbclass.SelectedItem = editClass;
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            General connstring = new General();
            string connectionString = connstring.getconnectionString(); //get string from the form Students
            lblerror.Text = "";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = null;
                    //UPDATE QUERY
                    if (editMode == true)
                    {
                        query = "UPDATE DB_Employees SET Firstname=@Firstname,Lastname=@Lastname,Birthday=@Birthday,Address=@Address,Nationality=@Nationality,HomeTelNum=@HomeTelNum,MobileTelNum=@MobileTelNum,AssignedClass=@AssignedClass,Salary=@Salary,Sex=@Sex,SocialInsNum=@SocialInsNum,IDNum=@IDNum WHERE ID=" + editID;
                    }
                    //INSERT QUERY
                    else if (editMode == false)
                    {
                        query = "INSERT DB_Employees (Firstname,Lastname,Birthday,Address,Nationality,HomeTelNum,MobileTelNum,AssignedClass,Salary,Sex,SocialInsNum,IDNum) VALUES (@Firstname,@Lastname,@Birthday,@Address,@Nationality,@HomeTelNum,@MobileTelNum,@AssignedClass,@Salary,@Sex,@SocialInsNum,@IDNum)";
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
                        sqlCmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value);
                    }
                    //Address
                    if (txtboxaddress.Text.Trim() == "" || txtboxaddress.Text == null)
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
                    //Sex
                    if (cmbboxsex.SelectedItem == null)
                    {
                        lblerror.Text = "Field Sex cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Sex", cmbboxsex.SelectedItem);
                    }
                    //HomeTel
                    if (txtboxhomenum.Text.Trim() == "" || txtboxhomenum.Text == null)
                    {
                        lblerror.Text = "Field Home telephone cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@HomeTelNum", txtboxhomenum.Text.Trim());
                    }
                    //MobileTel
                    if (txtboxmobilenum.Text.Trim() == "" || txtboxmobilenum.Text == null)
                    {
                        lblerror.Text = "Field Mobile number cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@MobileTelNum", txtboxmobilenum.Text.Trim());
                    }
                    //SocialInsNum
                    if (txtboxsocialins.Text.Trim() == "" || txtboxsocialins.Text == null)
                    {
                        lblerror.Text = "Field Social Insurance cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@SocialInsNum", txtboxsocialins.Text.Trim());
                    }
                    //IDNum
                    if (txtboxid.Text.Trim() == "" || txtboxid.Text == null)
                    {
                        lblerror.Text = "Field ID Number cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@IDNum", txtboxid.Text.Trim());
                    }
                    //Class
                    if (cmbclass.SelectedItem == null)
                    {
                        lblerror.Text = "Class cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@AssignedClass", cmbclass.SelectedItem);
                    }
                    //Salary
                    if (txtboxsalary.Text == "" || txtboxsalary.Text == null)
                    {
                        lblerror.Text = "Salary cannot be empty";
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@Salary", txtboxsalary.Text);
                    }

                    //If there are no errors
                    if (lblerror.Text == "")
                    {
                        sqlCmd.ExecuteNonQuery();
                        lblerror.ForeColor = System.Drawing.Color.Green;
                        if (editMode == true)//Specific actions to EDIT MODE
                        {
                            lblerror.Text = "Record Succesfully Edited.";
                        }
                        else //Specific actions for INSERT MODE
                        {
                            lblerror.Text = "New Record Added.";
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
                MessageBox.Show(ex.ToString(), "Exception Error");
                lblerror.Text = ex.ToString();
            }
        }
    }
}
