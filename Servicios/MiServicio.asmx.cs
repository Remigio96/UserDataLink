using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Servicios
{
    /// <summary>
    /// Summary description for MiServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MiServicio : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet Listado()
        {
            BD ObjBD = new BD();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM usuario", ObjBD.AbrirCon());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet ListadoParametro(string rut)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CRMCLI;User ID=sa;Password=S$vOvl74";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM usuario WHERE rut = '" + rut + "'", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
