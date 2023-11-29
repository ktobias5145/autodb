using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDb_Data_Insertion_Tool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        [STAThread]
        static void Main()
        {
            //Create new Sql Connection
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window1(cnn));
        }
    }
}
