using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public int IDVoucher { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; } // 0-sin usar 1-usado
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
