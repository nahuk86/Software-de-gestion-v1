using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Interfaces;
using System.Configuration;
using BLL.DTOs;

namespace UI.Forms.Forms_gerente
{
    public partial class form_crear_usuario : Form
    {
        private readonly UsuarioService _usuarioService;

        public form_crear_usuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que _usuarioService esté inicializado
                if (_usuarioService == null)
                {
                    MessageBox.Show("El servicio de usuario no está disponible.");
                    return;
                }

                // Capturar los datos del formulario y validar que los controles no sean null
                if (string.IsNullOrWhiteSpace(input_email.Text) || string.IsNullOrWhiteSpace(input_password.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                UsuarioDTO nuevoUsuario = new UsuarioDTO
                {
                    Username = input_email.Text,
                    Password = input_password.Text,
                    Email = input_email.Text,
                    Nombre = input_nombre.Text,
                    Apellido = input_apellido.Text,
                    DNI = input_dni.Text,
                    Rol = comboBox_rol.SelectedItem?.ToString()
                };

                // Verificar que Rol no sea null
                if (string.IsNullOrWhiteSpace(nuevoUsuario.Rol))
                {
                    MessageBox.Show("Por favor, seleccione un rol.");
                    return;
                }

                // Llamar al servicio para crear el usuario
                _usuarioService.CrearUsuario(nuevoUsuario);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Usuario creado con éxito.");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al crear el usuario: {ex.Message}");
            }
        }

        private void input_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}