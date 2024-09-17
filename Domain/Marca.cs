using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain
{
    public class Marca : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
