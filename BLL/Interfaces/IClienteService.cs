using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IClienteService
    {
        void CrearCliente(string nombre, string apellido, string dni, string telefono, string direccion, string email, DateTime fechaNacimiento);
    }
}
