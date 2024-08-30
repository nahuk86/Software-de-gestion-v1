using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UIHandlers
{
    public class GerenteUIHandler : IRoleBasedUI
    {
        public void MostrarUI()
        {
            Home_gerente formGerente = new Home_gerente();
            formGerente.Show();
        }
        public void MostrarUI(IClienteService clienteService)
        {
            MostrarUI(); // Llamar al método sin parámetros
        }
    }
}
