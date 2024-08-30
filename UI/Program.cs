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

namespace UI
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear las instancias de UI Handlers
            var depositoUIHandler = new DepositoUIHandler();
            var gerenteUIHandler = new GerenteUIHandler();
            var vendedorUIHandler = new VendedorUIHandler();
            var connectionString = "Server=NAHUEL-WINDOWS\\SQLEXPRESS;Database=GestionLocalesTelefoniaDB;Integrated Security=True;";

            IClienteService clienteService = new ClienteService(connectionString);

            // Crear la instancia de la fábrica de UI
            var uiFactory = new RoleBasedUIFactory(depositoUIHandler, gerenteUIHandler, vendedorUIHandler);

            // Configuración manual de la cadena de conexión
            var usuarioService = new UsuarioService(connectionString);

            // Iniciar la aplicación con la pantalla de inicio de sesión
            var loginForm = new Pantalla_inicio(usuarioService, uiFactory, clienteService);
            Application.Run(loginForm);

            // Una vez que Pantalla_inicio se cierre, podrías abrir otro formulario según sea necesario.
            // Sin embargo, no debes llamar a Application.Run más de una vez.
        }
    }
}
