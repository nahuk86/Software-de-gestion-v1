using BLL;
using UI.UIHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear las instancias de UI Handlers
            var depositoUIHandler = new DepositoUIHandler();
            var gerenteUIHandler = new GerenteUIHandler();
            var vendedorUIHandler = new VendedorUIHandler();

            // Crear la instancia de la fábrica de UI
            var uiFactory = new RoleBasedUIFactory(depositoUIHandler, gerenteUIHandler, vendedorUIHandler);


            // Configuración manual de la cadena de conexión
            var connectionString = "Server=NAHUEL-WINDOWS\\SQLEXPRESS;Database=GestionLocalesTelefoniaDB;Integrated Security=True;"; // Coloca tu cadena de conexión aquí
            var usuarioService = new UsuarioService(connectionString);

            // Pasar el usuarioService y la fábrica a LoginForm
            Application.Run(new Pantalla_inicio(usuarioService, uiFactory));
        }
    }
}