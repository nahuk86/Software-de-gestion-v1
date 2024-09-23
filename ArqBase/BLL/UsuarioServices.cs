using ArqBase.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqBase.Domain;

namespace ArqBase.BLL
{
    public class UsuarioServices
    {
        UsuariosRepository _usuarios;
        public UsuarioServices()
        {
            _usuarios = new UsuariosRepository();
        }

        public List<Usuario> GetAll()
        {
            return _usuarios.GetAll();
        }

        public void GuardarPermisos(Usuario u)
        {
            _usuarios.GuardarPermisos(u);
        }
    }
}

