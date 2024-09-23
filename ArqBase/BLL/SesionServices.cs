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
    }
}
