using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UIHandlers
{
    public class VendedorUIHandler : IRoleBasedUI
    {

        public void MostrarUI(IClienteService clienteService)
        {
            Home_vendedor formVendedor = new Home_vendedor(clienteService);
            formVendedor.Show();
        }

        public void MostrarUI()
        {
            throw new NotImplementedException("Este UIHandler requiere ClienteService.");
        }
    }
}