using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductoDTO
    {
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public int IdMarca { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
