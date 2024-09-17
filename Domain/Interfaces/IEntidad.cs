using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEntidad
    {
        int Id { get; set; }

        string Nombre { get; set; }
    }
}
