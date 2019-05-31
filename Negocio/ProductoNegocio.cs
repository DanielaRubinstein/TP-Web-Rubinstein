using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ProductoNegocio
    {
        //traer los productos desde la base de datos 
        //para mostrar en la web (carrousel por mundos)

        public Producto MostrarProducto(int Id)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Producto producto;
            try
            {
                accesoDatos.setearConsulta("Select * from Productos where Id=@Id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Id", Id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                producto = new Producto();
                if (accesoDatos.Lector.HasRows)
                {
                    accesoDatos.Lector.Read();
                    producto.Id = (int)accesoDatos.Lector["Id"];
                    producto.Titulo = accesoDatos.Lector["Titulo"].ToString();
                    producto.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    producto.URLImagen = accesoDatos.Lector["URLImagen"].ToString();
                    
                }
                return producto;

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
