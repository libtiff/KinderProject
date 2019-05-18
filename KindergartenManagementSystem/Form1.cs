using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace KindergartenManagementSystem
{
    public partial class frmMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
            );

        public frmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        int TogMove;
        int MValx;
        int MValy;

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


        //Top-Right Corner Exit Button
        private void Btnexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            updategrid();
            this.chart1.Series["Series1"].Points.AddXY("Bus", lbltotalbususers.Text);
            this.chart1.Series["Series1"].Points.AddXY("Non Bus", int.Parse(lbltotalstudents.Text)-int.Parse(lbltotalbususers.Text));
            this.chart1.Series["Series1"].Points.AddXY("Lunch", lbltotallunchusers.Text);
            this.chart1.Series["Series1"].Points.AddXY("Non Lunch", int.Parse(lbltotalstudents.Text) - int.Parse(lbltotallunchusers.Text));
        }

        void fetchstats(string query , int choice)
        {
            General connstring = new General();
            var conn = new SqlConnection(connstring.getconnectionString()); // Your Connection String here
            try
                {
                    using (conn)
                    {
                        SqlCommand comm = new SqlCommand(query, conn);
                        conn.Open();
                        switch (choice)
                        {
                            case 0:
                                {
                                    lbltotalbususers.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 1:
                                {
                                    lbltotallunchusers.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 2:
                                {
                                    lbltotalstudents.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 3:
                                {
                                    lbltotalemployees.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 4:
                                {
                                    lbltotalclasses.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 5:
                                {
                                    lbltotalteachers.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 6:
                                {
                                    lbltotalassistants.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 7:
                                {
                                    lbltotalcleaners.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 8:
                                {
                                    lbltotalmanagers.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }
                            case 9:
                                {
                                    lbltotalbusdrivers.Text = comm.ExecuteScalar().ToString();
                                    break;
                                }

                        }
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }

        private void updategrid()
        {
            string querybus = "SELECT COUNT(*) FROM dbo.DB_Students WHERE UsesBus=1";
            string querylunch = "SELECT COUNT(*) FROM dbo.DB_Students WHERE UsesLunch=1";
            string querytotalstuds = "SELECT COUNT(*) FROM dbo.DB_Students";
            string querytotalemps = "SELECT COUNT(*) FROM dbo.DB_Employees";
            string querytotalclasses = "SELECT COUNT(*) FROM dbo.DB_Classes";
            string querytotalteachers = "SELECT COUNT(*) FROM dbo.DB_Employees WHERE AssignedClass='Teacher'";
            string querytotalassistants = "SELECT COUNT(*) FROM dbo.DB_Employees WHERE AssignedClass='Assistant'";
            string querytotalcleaners = "SELECT COUNT(*) FROM dbo.DB_Employees WHERE AssignedClass='Cleaner'";
            string querytotalmanagers = "SELECT COUNT(*) FROM dbo.DB_Employees WHERE AssignedClass='Manager'";
            string querytotalbusdrivers = "SELECT COUNT(*) FROM dbo.DB_Employees WHERE AssignedClass='Bus Driver'";

            //   CHOICE GRID DEFINITION
            //   0: UsesBus
            //   1: UsesLunch
            //   2: GetTotalStuds
            //   3: GetTotalEmps
            //   4: GetTotalClasses
            //   5: GetTotalTeachers
            //   6: GetTotalAssistants
            //   7: GetTotalCleaners    
            //   8: GetTotalManagers
            //   9: GetTotalBusDrivers

            fetchstats(querybus, 0);    //Execute bus stats query
            fetchstats(querylunch, 1); //Execute lunch stats query
            fetchstats(querytotalstuds, 2); //Execute student stats query
            fetchstats(querytotalemps, 3); //Execute employees stats query
            fetchstats(querytotalclasses, 4); //Execute classes stats query
            fetchstats(querytotalteachers, 5); //Execute teachers stats query
            fetchstats(querytotalassistants, 6); //Execute assistants stats query
            fetchstats(querytotalcleaners, 7); //Execute cleaners stats query
            fetchstats(querytotalmanagers, 8); //Execute managers stats query
            fetchstats(querytotalbusdrivers, 9); //Execute busdrivers stats query
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
            updategrid();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            FrmClasses ClassFrm = new FrmClasses();
            ClassFrm.ShowDialog();
            //updategrid();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FrmEmployees frmemp = new FrmEmployees();
            frmemp.ShowDialog();
            updategrid();
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            FrmFinancial frmfinance = new FrmFinancial();
            frmfinance.ShowDialog();
        }

        private void btnmain_Click(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
           Payments frmpay = new Payments();
            frmpay.ShowDialog();
        }
    }
}
