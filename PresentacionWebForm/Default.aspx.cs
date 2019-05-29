using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace PresentacionWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BOTON_Click(object sender, EventArgs e)
        {
            ClienteNegocio cline = new ClienteNegocio();
            Cliente cliente = cline.PrecargarCliente(2);

        }
    }
}