using BLL;
using UI.UIHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using BLL.Interfaces;
using UI.Forms.Forms_vendedor;
using System.Configuration;
using System.Data.Common;
using UI.Forms.Forms_gerente;
using Servicios.BLL;

namespace UI
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Obtener la cadena de conexión desde App.config
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Crear las instancias de UI Handlers
            var depositoUIHandler = new DepositoUIHandler();
            var gerenteUIHandler = new GerenteUIHandler();
            var vendedorUIHandler = new VendedorUIHandler();
            var usuarioService = new UsuarioService();


            // Crear la instancia de la fábrica de UI
            var uiFactory = new RoleBasedUIFactory(depositoUIHandler, gerenteUIHandler, vendedorUIHandler);

            // Configuración manual de la cadena de conexión

            // Iniciar la aplicación con la pantalla de inicio de sesión

            IClienteService clienteService = new ClienteService(connectionString, usuarioService); // Pasamos el objeto usuarioService

            var loginForm = new Pantalla_inicio(usuarioService, uiFactory, clienteService);


            Application.Run(loginForm);

        }
    }
}