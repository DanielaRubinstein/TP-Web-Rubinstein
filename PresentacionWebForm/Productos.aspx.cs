using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Negocio;
using Dominio;

namespace PresentacionWebForm
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> producto = productoNegocio.mostrarProducto();
            dgvProducto.DataSource = producto;
            dgvProducto.DataBind();

        }



    }
}