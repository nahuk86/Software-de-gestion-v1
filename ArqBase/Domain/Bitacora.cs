using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.Domain
{
    public class Bitacora
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
    }
}