using ArqBase.BLL;
using BLL;
using BLL.Interfaces;
using BLL.Services;
using Servicios.BLL;
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
        private readonly UsuarioServices _usuarioService;
        private readonly RoleBasedUIFactory _uiFactory;
        private readonly IClienteService _clienteService;
        private readonly PermisosServices _permisosService;



        public Pantalla_inicio(UsuarioServices usuarioService, RoleBasedUIFactory uiFactory, IClienteService clienteService, PermisosServices permisosService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _uiFactory = uiFactory;
            _clienteService = clienteService;
            _permisosService = permisosService;
        }

        private void button_access_Click(object sender, EventArgs e)
        {
            string email = input_txt_username.Text.Trim();
            string enteredPassword = input_txt_password.Text;

            // Retrieve the user from the database
            var usuario = _usuarioService.ObtenerUsuario(email);

            if (usuario != null && PasswordHasher.VerifyPassword(enteredPassword, usuario.Password))
            {
                // Password matches, authenticate user and load permissions
                _permisosService.FillUserComponents(usuario);

                // Redirect to the appropriate user interface based on their permissions
                List<string> rolesUsuario = _usuarioService.ObtenerRolesUsuario(usuario);
                foreach (var rol in rolesUsuario)
                {
                    // Handle roles dynamically, for example:
                    if (rol == "Gerente")
                    {
                        Home_gerente formGerente = new Home_gerente();
                        formGerente.Show();
                    }
                    else if (rol == "Vendedor")
                    {
                        Home_vendedor home_Vendedor = new Home_vendedor(_clienteService);
                        home_Vendedor.Show();
                    }
                    else if (rol == "Deposito")
                    {
                        Home_deposito Home_deposito = new Home_deposito();
                        Home_deposito.Show();
                    }
                }
            }
            else
            {
                // Invalid credentials
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