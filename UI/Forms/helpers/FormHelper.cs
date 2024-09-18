using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI.Forms.helpers
{
    public static class FormHelper
    {
        public static void CargarDatos(ProductoService productoService,
                                       ComboBox comboBox_categoria_producto,
                                       ComboBox comboBox_proveedor_producto,
                                       ComboBox comboBox_marca_producto)
        {
            var categorias = productoService.ObtenerCategorias();
            comboBox_categoria_producto.DataSource = categorias;
            comboBox_categoria_producto.DisplayMember = "Nombre";
            comboBox_categoria_producto.ValueMember = "Id";

            var proveedores = productoService.ObtenerProveedores();
            comboBox_proveedor_producto.DataSource = proveedores;
            comboBox_proveedor_producto.DisplayMember = "Nombre";
            comboBox_proveedor_producto.ValueMember = "Id";

            var marcas = productoService.ObtenerMarcas();
            comboBox_marca_producto.DataSource = marcas;
            comboBox_marca_producto.DisplayMember = "Nombre";
            comboBox_marca_producto.ValueMember = "Id";
        }
    }
}
