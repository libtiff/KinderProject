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
    public partial class FrmFinancial : Form
    {
        public FrmFinancial()
        {
            InitializeComponent();
        }

        private int inc = 0;
        private int sal = 0;
        private int net = 0;

        private void FrmFinancial_Load(object sender, EventArgs e)
        {

            string querytotaltuition = "SELECT SUM (MonthlyFee) FROM dbo.DB_Students";
            string querysalaries = "SELECT SUM (Salary) FROM dbo.DB_Employees";
            string querytotalstuds = "SELECT COUNT(*) FROM dbo.DB_Students";
            string querytotalemps = "SELECT COUNT(*) FROM dbo.DB_Employees";
            string querytotalclasses = "SELECT COUNT(*) FROM dbo.DB_Classes";

            //   CHOICE GRID DEFINITION
            //   0: TotalTuitionFees
            //   1: TotalSalaries

            fetchstats(querytotaltuition,0);    //Execute bus stats query
            fetchstats(querysalaries, 1);    //Execute bus stats query
            net = inc - sal;
            lblnettotal.Text = net.ToString();
            lblyearlynettotal.Text = (net * 12).ToString();

            this.chart1.Series["Series1"].Points.AddXY("Income",inc);
            this.chart1.Series["Series1"].Points.AddXY("Salaries", sal);
            this.chart1.Series["Series1"].Points.AddXY("Net Amount", net);

        }

        void fetchstats(string query, int choice)
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
                                lbltotalrevenue.Text = comm.ExecuteScalar().ToString();
                                inc = int.Parse(lbltotalrevenue.Text);
                                lblyearlyrevenue.Text = (inc * 12).ToString();
                                break;
                            }
                        case 1:
                            {
                                lblsalaries.Text = comm.ExecuteScalar().ToString();
                                sal = int.Parse(lblsalaries.Text);
                                lblyearlysalaries.Text = (sal * 12).ToString();
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

    }
}
