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
using DAL.Repositories;
using System.Configuration;
using BLL.DTOs;


namespace BLL
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _usuarioRepository = new UsuarioRepository(connectionString);
        }

        // Método para autenticar un usuario
        public bool AutenticarUsuario(string username, string password)
        {
            var usuario = _usuarioRepository.ObtenerUsuarioPorNombre(username);

            if (usuario == null)
            {
                // Usuario no encontrado
                return false;
            }

            // Depurar los valores
            Console.WriteLine("Stored Hash: " + usuario.Password);
            Console.WriteLine("Entered Password: " + password);

            // Verificar la contraseña encriptada
            bool isValid = PasswordHasher.VerifyPassword(password, usuario.Password);
            Console.WriteLine("Password Valid: " + isValid);

            return isValid;
        }

        // Método para obtener el rol de un usuario
        public string ObtenerRolUsuario(string username)
        {
            var usuario = _usuarioRepository.ObtenerUsuarioPorNombre(username);
            if (usuario == null)
                return null;

            return _usuarioRepository.ObtenerRolPorUsuarioId(usuario.Id);
        }

        // Método para crear un usuario
        public void CrearUsuario(UsuarioDTO usuarioDTO)
        {
            // Convertir el DTO a la entidad del dominio
            Usuario usuario = new Usuario
            {
                Username = usuarioDTO.Username,
                Password = usuarioDTO.Password,
                Email = usuarioDTO.Email,
                Nombre = usuarioDTO.Nombre,
                Apellido = usuarioDTO.Apellido,
                DNI = usuarioDTO.DNI,
                Rol = usuarioDTO.Rol
            };

            // Guardar el usuario en la base de datos
            _usuarioRepository.CrearUsuario(usuario);
        }

        // Método para encriptar la contraseña
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}