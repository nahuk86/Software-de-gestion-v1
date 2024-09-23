using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.BLL.Accesos
{
    public class AccesosServices
    {
        public void Alta_usuario()
        {
            if (!Sesion.GetInstance.IsInRole(TipoPermiso.Alta_usuario)) throw new Exception("No tiene permisos");
        }
    }
}
