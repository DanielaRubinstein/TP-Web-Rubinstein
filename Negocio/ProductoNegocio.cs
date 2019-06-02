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

        public List<Producto> mostrarProducto()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            List<Producto> listaProducto = new List<Producto>();
            Producto producto;
            try
            {
                accesoDatos.setearConsulta("Select Id,Titulo,Descripcion,URLImagen from Productos");
                //accesoDatos.Comando.Parameters.Clear();
                //accesoDatos.Comando.Parameters.AddWithValue("@Id");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    producto = new Producto();  
                    producto.Id = (Int64)accesoDatos.Lector["Id"];
                    producto.Titulo = accesoDatos.Lector["Titulo"].ToString();
                    producto.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    producto.URLImagen = accesoDatos.Lector["URLImagen"].ToString();
                    listaProducto.Add(producto);
                }
                return listaProducto;
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


        //public Producto seleccionProducto(Int64 Id)
        //{
        //    AccesoDatosManager accesoDatos = new AccesoDatosManager();
        //    Producto producto;
        //}


    }
}
