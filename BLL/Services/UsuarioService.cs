using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ArqBase;

namespace BLL
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(string connectionString)
        {
            _usuarioRepository = new UsuarioRepository(connectionString);
        }

        public bool AutenticarUsuario(string username, string password)
        {
            var usuario = _usuarioRepository.ObtenerUsuarioPorNombre(username);

            if (usuario == null)
                return false;

            return usuario.Password == password;
        }

        public string ObtenerRolUsuario(string username)
        {
            var usuario = _usuarioRepository.ObtenerUsuarioPorNombre(username);
            if (usuario == null)
                return null;

            return _usuarioRepository.ObtenerRolPorUsuarioId(usuario.Id);
        }
    }
}