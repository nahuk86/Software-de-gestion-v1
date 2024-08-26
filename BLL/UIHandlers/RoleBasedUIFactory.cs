using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBasedUIFactory
    {
        private readonly IRoleBasedUI _depositoUI;
        private readonly IRoleBasedUI _gerenteUI;
        private readonly IRoleBasedUI _vendedorUI;

        public RoleBasedUIFactory(IRoleBasedUI depositoUI, IRoleBasedUI gerenteUI, IRoleBasedUI vendedorUI)
        {
            _depositoUI = depositoUI;
            _gerenteUI = gerenteUI;
            _vendedorUI = vendedorUI;
        }

        public IRoleBasedUI GetUIHandler(string rolUsuario)
        {
            if (rolUsuario.ToLower() == "deposito")
            {
                return _depositoUI;
            }
            else if (rolUsuario.ToLower() == "gerente")
            {
                return _gerenteUI;
            }
            else if (rolUsuario.ToLower() == "vendedor")
            {
                return _vendedorUI;
            }
            else
            {
                return null;
            }
        }
    }
}
