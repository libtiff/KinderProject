using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenManagementSystem
{
    public partial class FrmLogin : Form
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

        public FrmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //int attemptscounter;
            //int ConnMaxTries;
            //string uname = "";
            //string pword = "";

            //General connstring = new General();
            //SqlConnection sqlCon = new SqlConnection(connstring.getconnectionString());
            //string query = "SELECT * FROM dbo.DB_Logins WHERE ID=1";
            //SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            //try
            //{
            //    sqlCon.Open();
            //    using (SqlDataReader read = sqlCmd.ExecuteReader())
            //    {
            //        while (read.Read())
            //        {
            //            uname = (read["Username"].ToString());
            //            pword = (read["Password"].ToString());
            //            attemptscounter = int.Parse((read["ConnTries"].ToString()));
            //            ConnMaxTries = int.Parse((read["ConnMaxTries"].ToString()));
            //            sqlCon.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    sqlCon.Close();
            //}
            if (txtboxusername.Text == "admin" && txtboxpassword.Text == "admin")
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            RoundObjects rnd = new RoundObjects();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
