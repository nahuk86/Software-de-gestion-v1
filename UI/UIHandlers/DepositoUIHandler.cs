using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;


namespace UI.UIHandlers
{
    public class DepositoUIHandler : IRoleBasedUI
    {
        public void MostrarUI()
        {
            Home_deposito formDeposito = new Home_deposito();
            formDeposito.Show();
        }
    }
}