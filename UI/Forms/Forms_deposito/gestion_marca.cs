using BLL;
using BLL.Services;
using Servicios.BLL;
using Servicios.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Forms_deposito
{
    public partial class gestion_marca : Form
    {

        private ProductoService productoService;
        private BitacoraService bitacoraService;
        private UsuarioService usuarioService;
        public gestion_marca()
        {
            InitializeComponent();
            // Crear instancia de BitacoraRepository
            BitacoraRepository bitacoraRepository = new BitacoraRepository();

            // Crear instancia de BitacoraService con el repositorio
            bitacoraService = new BitacoraService(bitacoraRepository);

            // Crear instancia de UsuarioService (Asegúrate de que UsuarioService esté correctamente definido)
            usuarioService = new UsuarioService();

            // Crear instancia de ProductoService con las dependencias
            productoService = new ProductoService(bitacoraService, usuarioService);
        }

        private void btn_agregar_marca_Click(object sender, EventArgs e)
        {
            try
            {
                productoService.AgregarMarca(textBox1.Text);
                MessageBox.Show("Marca agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la marca: {ex.Message}");
            }
        }
    }
}
