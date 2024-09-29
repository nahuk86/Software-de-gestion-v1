using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.helpers
{
    public class FormFactory
    {
        private readonly Dictionary<string, Type> _forms = new Dictionary<string, Type>();

        public FormFactory()
        {
            // Registra los formularios que se pueden crear
            _forms.Add("Gerente", typeof(Home_gerente));
            _forms.Add("Vendedor", typeof(Home_vendedor));
            _forms.Add("Deposito", typeof(Home_deposito));
        }

        public Form CreateForm(List<string> roles)
        {
            // Crea una instancia del formulario correspondiente al rol del usuario
            foreach (var rol in roles)
            {
                if (_forms.ContainsKey(rol))
                {
                    return (Form)Activator.CreateInstance(_forms[rol]);
                }
            }

            // Si no se encuentra un formulario para el rol, devuelve null
            return null;
        }
    }

}
