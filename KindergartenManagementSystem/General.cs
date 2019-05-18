using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenManagementSystem
{
   
    class General
    {
        private string connectionString { get; set; }

        public General()
        {
            //LocalConnection String
            //private static string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DB_Kindergarten;Integrated security=true";
            //Azzure Connection String
            connectionString = "Data Source=tcp:libtiff.database.windows.net,1433;Initial Catalog=DB_Kindergarten;User ID=DBOWNER;Password=Test1234!";
        }

        public string getconnectionString()
        {
            return connectionString;
        }
    }     
}
