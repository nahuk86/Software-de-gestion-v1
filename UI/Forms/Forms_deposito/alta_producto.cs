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

namespace UI.Forms.Forms_deposito
{
    public partial class alta_producto : Form
    {
        private ProductoService productoBLL = new ProductoService();


        public alta_producto()
        {
            InitializeComponent();
            productoBLL = new ProductoService(); // Crear una instancia de ProductoBLL
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Cargar Categorías
            var categorias = productoBLL.ObtenerCategorias();
            comboBox_categoria_producto.DataSource = categorias;

            // Cargar Proveedores
            var proveedores = productoBLL.ObtenerProveedores();
            comboBox_proveedor_producto.DataSource = proveedores;

            // Cargar Marcas
            var marcas = productoBLL.ObtenerMarcas();
            comboBox_marca_producto.DataSource = marcas;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_agregar_producto_Click(object sender, EventArgs e)
        {

        }
    }
}
