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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ProductoNegocio productoNegocio = new ProductoNegocio();
            //List<Producto> producto = productoNegocio.mostrarProducto();
            //dgvProducto.DataSource = producto;
            //dgvProducto.DataBind();

        }

        protected void btnVoucher_Click(object sender, EventArgs e)
        {
            Session.Add("codigo",txtVoucher.Text);
            Response.Redirect("~/Productos.aspx");
        }

        protected void txtVoucher_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/prueba.aspx");
        }
    }
}