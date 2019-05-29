using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void agregarCliente(Cliente nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("Insert into Clientes (DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal, FechaRegistro) " +
                    "values(@DNI, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CodigoPostal, @FechaRegistro)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@DNI", nuevo.DNI);
                accesoDatos.Comando.Parameters.AddWithValue("Nombre", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@Email", nuevo.Email);
                accesoDatos.Comando.Parameters.AddWithValue("@Direccion", nuevo.Direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@Ciudad", nuevo.Ciudad);
                accesoDatos.Comando.Parameters.AddWithValue("@CodigoPostal", nuevo.CodigoPostal);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaRegistro", nuevo.FechaRegistro);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        
        }

        //Precargar los datos del cliente, si ya esta ingresado

        public Cliente PrecargarCliente(int DNI)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Cliente cliente;
            try
            {
                accesoDatos.setearConsulta("Select * from Clientes where DNI=@DNI");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@DNI",DNI);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                //validar si existe algun cliente
                cliente = new Cliente();
                if (accesoDatos.Lector.HasRows)
                { 
                accesoDatos.Lector.Read();
                cliente.IDCliente = (int)accesoDatos.Lector["Id"];
                cliente.DNI = (int)accesoDatos.Lector["DNI"];
                cliente.Nombre = accesoDatos.Lector["Nombre"].ToString();
                cliente.Apellido = accesoDatos.Lector["Apellido"].ToString();
                cliente.Email = accesoDatos.Lector["Email"].ToString();
                cliente.Direccion = accesoDatos.Lector["Direccion"].ToString();
                cliente.Ciudad = accesoDatos.Lector["Ciudad"].ToString();
                cliente.CodigoPostal = accesoDatos.Lector["CodigoPostal"].ToString();
                cliente.FechaRegistro = (DateTime)accesoDatos.Lector["FechaRegistro"];
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

            return cliente;
        }

    }
}
