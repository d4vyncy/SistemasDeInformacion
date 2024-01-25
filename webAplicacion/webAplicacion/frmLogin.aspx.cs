using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webAplicacion.Servicios;
using webAplicacion.Servicios.Models;

namespace webAplicacion
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicioAutenticar oservicioAutenticar = new servicioAutenticar();
            usuarioLogin ousuarioLogin = oservicioAutenticar.RecuperaToken(txtUsuario.Text.ToString(), txtPassword.Text.ToString());
            
            if (ousuarioLogin.token != null) {
                Session.Add("ousuarioLogin", ousuarioLogin);
                Response.Redirect("./Formularios/wfRol.aspx");
            }
            

        }
    }
}