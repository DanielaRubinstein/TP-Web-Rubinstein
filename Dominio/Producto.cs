using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public Int64 Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string URLImagen { get; set; }

        public override string ToString()
        {
            return Id + " ," + Titulo + " ," + Descripcion + " ," + URLImagen;
        }
    }
}
