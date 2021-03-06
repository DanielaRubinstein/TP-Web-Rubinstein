﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class VoucherNegocio
    {

        //Chequear si existe y el estado
        //Si se usa, que cambie el estado
        //Si es correcto el paso siguiente será
        //seleccionar el premio por el cual se quiere participar.
        //Si el código de voucher es incorrecto, se
        //deberá notificar al usuario en una pantalla aclaratoria 
        //con un botón para redirigir al inicio.
        public bool ValidarVoucher(string CodigoVoucher)
        {
            List<Voucher> listado = new List<Voucher>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Voucher voucher;
            try
            {
                accesoDatos.setearConsulta("Select CodigoVoucher from Vouchers where CodigoVoucher=@CodigoVoucher and Estado=0");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@CodigoVoucher", CodigoVoucher);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    voucher = new Voucher();
                    voucher.CodigoVoucher = accesoDatos.Lector["CodigoVoucher"].ToString();
                    listado.Add(voucher);
                }

                if (listado.Count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void CambiarEstado(Voucher modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("Update Vouchers set Estado=@Estado where CodigoVoucher=" + modificar.CodigoVoucher.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", 1); //1-usado
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
