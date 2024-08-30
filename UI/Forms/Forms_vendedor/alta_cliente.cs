using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Forms_vendedor
{
    public partial class alta_cliente : Form
    {

        private readonly IClienteService _clienteService;

        public alta_cliente(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {
            if (_clienteService == null)
            {
                MessageBox.Show("El servicio de cliente no está disponible. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Asegúrate de que _clienteService no es null
                if (_clienteService == null)
                {
                    MessageBox.Show("El servicio de cliente no está disponible. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Captura los datos del formulario
                string nombre = txt_cliente_nombre.Text;
                string apellido = txt_cliente_apellido.Text;
                string dni = txt_cliente_dni.Text;
                string telefono = txt_cliente_telefono.Text;
                string direccion = txt_cliente_direccion.Text;
                string email = txt_cliente_email.Text;

                // Validar la fecha
                DateTime fechaNacimiento;
                if (!DateTime.TryParse(dateTimePicker_cliente_nacimiento.Text, out fechaNacimiento))
                {
                    MessageBox.Show("Fecha de nacimiento no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Asegurarse que la fecha es razonable (por ejemplo, no en el futuro)
                if (fechaNacimiento > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crea un nuevo cliente usando el servicio
                _clienteService.CrearCliente(nombre, apellido, dni, telefono, direccion, email, fechaNacimiento);

                MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepción
                MessageBox.Show($"Error al crear el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alta_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
