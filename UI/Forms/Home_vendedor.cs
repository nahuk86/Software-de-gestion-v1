using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Forms_vendedor;

namespace UI
{
    public partial class Home_vendedor : Form

    {

        private readonly IClienteService _clienteService;

        public Home_vendedor(IClienteService clienteService)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));

        }



        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrar_venta formHijo = new registrar_venta();
            formHijo.MdiParent = this;  // Configura el formulario padre
            formHijo.Show();

        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alta_cliente formHijo = new alta_cliente(_clienteService);
            formHijo.MdiParent = this;  // Configura el formulario padre
            formHijo.Show();

        }

        private void Home_vendedor_Load(object sender, EventArgs e)
        {

        }

        private void validarConexionSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
