using BLL.Services;
using BLL;
using Servicios.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.DAL.Repositories;

namespace UI.Forms.Forms_deposito
{
    public partial class alta_proveedor : Form
    {
        public event EventHandler MarcaAgregada;  // Definir el evento

        private ProductoService productoService;
        private BitacoraService bitacoraService;
        private UsuarioService usuarioService;
        public alta_proveedor()
        {
            InitializeComponent();
            BitacoraRepository bitacoraRepository = new BitacoraRepository();
            bitacoraService = new BitacoraService(bitacoraRepository);
            usuarioService = new UsuarioService();
            productoService = new ProductoService(bitacoraService, usuarioService);
        }

        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {
            try
            {
                productoService.AgregarProveedor(textBox_alta_proveedor.Text);
                MessageBox.Show("Proveedor agregado exitosamente.");
                MarcaAgregada?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el proveedor: {ex.Message}");
            }
        }
    }
}
