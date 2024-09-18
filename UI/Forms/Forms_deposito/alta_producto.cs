using BLL.Interfaces;
using BLL.Services;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Servicios.BLL;
using Servicios.DAL.Repositories;
using UI.Forms.Forms_vendedor;
using UI.Forms.helpers;

namespace UI.Forms.Forms_deposito
{
    public partial class alta_producto : Form
    {
        private ProductoService productoService;
        private BitacoraService bitacoraService;
        private UsuarioService usuarioService;


        public alta_producto()
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

            // Llamar al método de la clase FormHelper
            FormHelper.CargarDatos(productoService, comboBox_categoria_producto, comboBox_proveedor_producto, comboBox_marca_producto);

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
            try
            {
                // Obtener datos del formulario
                var nuevoProductoDTO = new ProductoDTO
                {
                    Nombre = textBox_nombre_producto.Text,
                    IdCategoria = (int)comboBox_categoria_producto.SelectedValue,
                    IdProveedor = (int)comboBox_proveedor_producto.SelectedValue,
                    IdMarca = (int)comboBox_marca_producto.SelectedValue,
                    ValorUnitario = decimal.Parse(textBox_valor_unitario_producto.Text)
                };

                // Llamar al método de la BLL para agregar el producto
                productoService.AgregarProducto(nuevoProductoDTO);

                MessageBox.Show("Producto agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }

        private void alta_producto_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_marca_Click(object sender, EventArgs e)
        {
            //this.Close();

            gestion_marca agregarMarcaForm = new gestion_marca();

            // Suscribir el evento MarcaAgregada al método CargarDatos del formulario alta_producto
            agregarMarcaForm.MarcaAgregada += (s, args) => FormHelper.CargarDatos(productoService, comboBox_categoria_producto, comboBox_proveedor_producto, comboBox_marca_producto);

            agregarMarcaForm.MdiParent = this.MdiParent;
            agregarMarcaForm.Show();

        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            alta_categoria agregarCategoriaForm = new alta_categoria();

            agregarCategoriaForm.MarcaAgregada += (s, args) => FormHelper.CargarDatos(productoService, comboBox_categoria_producto, comboBox_proveedor_producto, comboBox_marca_producto);

            // Set the MdiParent to the Home_deposito MDI parent form
            agregarCategoriaForm.MdiParent = this.MdiParent;

            // Show the agregar_marca form
            agregarCategoriaForm.Show();
        }
    }
}
