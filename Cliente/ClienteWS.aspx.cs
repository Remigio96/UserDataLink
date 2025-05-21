using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Cliente
{
    public partial class ClienteWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WsUsuario.MiServicioSoapClient WS = new WsUsuario.MiServicioSoapClient();
            DataSet ds = WS.Listado();
            grvUsuarios.DataSource = ds.Tables[0];
            grvUsuarios.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            WsUsuario.MiServicioSoapClient WS = new WsUsuario.MiServicioSoapClient();
            DataSet ds = WS.ListadoParametro(txtRut.Text);
            grvUsuarios.DataSource = ds.Tables[0];
            grvUsuarios.DataBind();
        }

    }
}