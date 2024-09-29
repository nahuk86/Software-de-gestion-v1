using ArqBase.DAL.Repositories;
using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.BLL
{
    public class SesionServices
    {
        public void Login(Usuario u)
        {
            (new PermisosRepository()).FillUserComponents(u);
            Sesion.GetInstance.Login(u);
        }

        public void Logout()
        {
            Sesion.GetInstance.Logout();
        }

        // Método para obtener el usuario con sesión activa
        public Usuario GetUsuarioActivo()
        {
            if (Sesion.GetInstance.IsLoggedIn())
            {
                return Sesion.GetInstance.GetUsuario();
            }
            else
            {
                return null; // O manejar el caso cuando no hay usuario activo
            }
        }
    }
}
