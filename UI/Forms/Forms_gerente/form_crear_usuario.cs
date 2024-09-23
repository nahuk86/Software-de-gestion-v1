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
using ArqBase.BLL;
using ArqBase.Domain;

namespace UI.Forms.Forms_gerente
{
    public partial class form_crear_usuario : Form
    {
        private readonly UsuarioServices _usuarioService;

        public form_crear_usuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioServices();
        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Usuario object with form inputs
                Usuario usuario = new Usuario
                {
                    Nombre = input_nombre.Text,
                    Apellido = input_apellido.Text,
                    DNI = input_dni.Text,
                    Email = input_email.Text,
                    Password = input_password.Text // Hash this before storing
                };

                // Call the service with a Usuario object
                _usuarioService.CrearUsuario(usuario);
                MessageBox.Show("Usuario creado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message}");
            }
        }

        private void input_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}