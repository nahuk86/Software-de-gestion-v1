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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Forms.Forms_deposito
{
    public partial class alta_categoria : Form
    {
        public event EventHandler MarcaAgregada;  // Definir el evento

        private ProductoService productoService;
        private BitacoraService bitacoraService;
        private UsuarioService usuarioService;
        public alta_categoria()
        {
            InitializeComponent();
            BitacoraRepository bitacoraRepository = new BitacoraRepository();
            bitacoraService = new BitacoraService(bitacoraRepository);
            usuarioService = new UsuarioService();
            productoService = new ProductoService(bitacoraService, usuarioService);
        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                productoService.AgregarCategoria(textBox_categoria.Text);
                MessageBox.Show("Categoria agregada exitosamente.");
                MarcaAgregada?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la categoria: {ex.Message}");
            }
        }
    }
}
