﻿using BLL;
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
using UI.Forms.helpers;

namespace UI.Forms.Forms_deposito
{
    public partial class gestion_marca : Form
    {
        public event EventHandler MarcaAgregada;  // Definir el evento

        private ProductoService productoService;
        private BitacoraService bitacoraService;
        private UsuarioService usuarioService;
        public gestion_marca()
        {
            InitializeComponent();
            BitacoraRepository bitacoraRepository = new BitacoraRepository();
            bitacoraService = new BitacoraService(bitacoraRepository);
            usuarioService = new UsuarioService();
            productoService = new ProductoService(bitacoraService, usuarioService);
        }

        private void btn_agregar_marca_Click(object sender, EventArgs e)
        {
            try
            {
                productoService.AgregarMarca(textBox1.Text);
                MessageBox.Show("Marca agregada exitosamente.");
                MarcaAgregada?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la marca: {ex.Message}");
            }
        }
    }
}
