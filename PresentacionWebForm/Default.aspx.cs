﻿using System;
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
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            bool checkVoucher = voucherNegocio.ValidarVoucher(txtVoucher.Text);
            if (checkVoucher==true)
            {
                Session.Add("codigo", txtVoucher.Text);
                Response.Redirect("~/Productos.aspx");
            }
            else
            {
                txtVoucher.Text = "Ingrese un código válido";
            }
        }

    }
}