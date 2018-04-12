using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace miniProjet
{
    class ConnexionBD
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        public SqlDataReader dr;

        public void connect()
        {
            try
            {

                con.ConnectionString = @"Data Source=.\HOUSSAM;Initial Catalog=BD_EmpPaie;Integrated Security=True";
                con.Open();
                com.Connection = con;
                com.CommandType = CommandType.Text;
            }
            catch
            {

            }


        }

    }
}
