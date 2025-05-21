using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Servicios
{
    public class BD
    {
        public SqlConnection AbrirCon()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DataBaseHere;User ID=UserHere;Password=PassHere");
            con.Open();
            return con;
        }
    }
}