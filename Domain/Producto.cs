using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public int IdMarca { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
