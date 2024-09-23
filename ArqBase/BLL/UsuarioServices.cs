using ArqBase.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqBase.Domain;
using ArqBase.DAL.Helper;
using System.Data.SqlClient;

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

        public Usuario ObtenerUsuario(string email)
        {
            // Query the database to retrieve the user by username
            var sql = @"SELECT * FROM usuarios WHERE email = @email;";
            Usuario usuario = null;

            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@email", email)))
            {
                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id_usuario")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Password = reader.GetString(reader.GetOrdinal("password")) // Retrieve hashed password
                    };
                }
            }

            return usuario;
        }

        public List<string> ObtenerRolesUsuario(Usuario usuario)
        {
            var sql = @"
        SELECT p.permiso 
        FROM usuarios_permisos up
        INNER JOIN permiso_permiso pp ON up.id_permiso = pp.id_permiso_padre
        INNER JOIN permiso p ON pp.id_permiso_hijo = p.id
        WHERE up.id_usuario = @id_usuario";

            List<string> roles = new List<string>();

            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@id_usuario", usuario.Id)))
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("permiso")))
                    {
                        roles.Add(reader.GetString(reader.GetOrdinal("permiso")));
                    }
                }
            }

            return roles; // Return all roles
        }
    }
}

