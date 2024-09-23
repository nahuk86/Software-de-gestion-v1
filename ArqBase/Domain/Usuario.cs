using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.Domain
{
    public class Usuario
    {
        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        List<Componente> _permisos;
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
