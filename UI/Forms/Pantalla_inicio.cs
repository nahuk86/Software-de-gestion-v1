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
using UI.Forms.helpers;
using ArqBase.Domain;

namespace UI
{
    public partial class Pantalla_inicio : Form
    {
        private readonly UsuarioServices _usuarioService;
        private readonly RoleBasedUIFactory _uiFactory;
        private readonly IClienteService _clienteService;
        private readonly PermisosServices _permisosService;
        private readonly SesionServices _sesionService;
        private readonly BitacoraService _bitacoraService;
        SesionServices sesionService = new SesionServices();
        UsuarioServices usuarioService = new UsuarioServices();
        PermisosServices permisosService = new PermisosServices();
        private Usuario usuariosesion;

        public Pantalla_inicio()
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _permisosService = permisosService;
            _sesionService = sesionService;
            _bitacoraService = new BitacoraService();

        }

        private void button_access_Click(object sender, EventArgs e)
        {
            string email = input_txt_username.Text.Trim();
            string enteredPassword = input_txt_password.Text;

            // Retrieve the user from the database
            var usuario = _usuarioService.ObtenerUsuario(email);

            if (usuario != null)
            {
                // Verify the password using a secure password verification algorithm
                if (PasswordHasher.VerifyPassword(enteredPassword, usuario.Password))
                {
                    // Password matches, authenticate user and load permissions
                    _permisosService.FillUserComponents(usuario);

                    // Redirect to the appropriate user interface based on their permissions
                    List<string> rolesUsuario = _usuarioService.ObtenerRolesUsuario(usuario);
                    _sesionService.Login(usuario);

                    // Use a dependency injection system to create instances of forms
                    var formFactory = new FormFactory();
                    var form = formFactory.CreateForm(rolesUsuario);

                    usuariosesion = sesionService.GetUsuarioActivo();

                    if (usuariosesion != null)
                    {
                        _bitacoraService.Registrar(usuariosesion.Email, "Inicio de sesion", $"Usuario con email {usuario.Email} ha iniciado sesion");
                    }
                    else
                    {
                        MessageBox.Show("No hay un usuario activo en la sesión.");
                    }
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Autenticación fallida. Por favor, inténtelo de nuevo.", "Autenticación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _bitacoraService.Registrar(email, "error de inicion de sesion", "Autenticación Fallida");

                }
            }
            else
            {
                // User not found
                MessageBox.Show("Usuario no encontrado.", "Autenticación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _bitacoraService.Registrar(email, "error de inicion de sesion", "Autenticación Fallida");


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