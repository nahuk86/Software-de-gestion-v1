using BLL;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Pantalla_inicio : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly RoleBasedUIFactory _uiFactory;
        private readonly IClienteService _clienteService;



        public Pantalla_inicio(UsuarioService usuarioService, RoleBasedUIFactory uiFactory, IClienteService clienteService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _uiFactory = uiFactory;
            _clienteService = clienteService;


        }


        private void IniciarAplicacionParaUsuario(string rolUsuario)
        {
            // Aquí definimos la lógica para iniciar la aplicación según el rol
            if (rolUsuario == "Gerente")
            {
                Home_gerente formGerente = new Home_gerente();
                formGerente.Show();
            }
            else if (rolUsuario == "Vendedor")
            {
                Home_vendedor home_Vendedor = new Home_vendedor(_clienteService);
                home_Vendedor.Show();
            }
            else if (rolUsuario == "Deposito")
            {
                Home_deposito home_Deposito = new Home_deposito();
                home_Deposito.Show();
            }
            else
            {
                MessageBox.Show("Rol de usuario no reconocido.");
            }

            // Opcional: puedes cerrar la pantalla de inicio si se navega a otra
            this.Close();
        }


        private void button_access_Click(object sender, EventArgs e)
        {
            string username = input_txt_username.Text.Trim();
            string password = input_txt_password.Text;

            bool autenticado = _usuarioService.AutenticarUsuario(username, password);

            if (autenticado)
            {
                string rolUsuario = _usuarioService.ObtenerRolUsuario(username);
                var uiHandler = _uiFactory.GetUIHandler(rolUsuario);

                if (uiHandler != null)
                {
                    if (rolUsuario == "Vendedor") // O cualquier otro rol que necesite ClienteService
                    {
                        var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                        IClienteService clienteService = new ClienteService(connectionString);
                        uiHandler.MostrarUI(clienteService);
                    }
                    else
                    {
                        uiHandler.MostrarUI();
                    }

                    this.Hide(); // Oculta el formulario de inicio de sesión
                }
                else
                {
                    MessageBox.Show("Rol de usuario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Autenticación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_inicio_Load(object sender, EventArgs e)
        {

        }
    }
}