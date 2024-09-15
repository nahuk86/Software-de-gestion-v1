using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Forms_deposito;
using UI.Forms.Forms_vendedor;

namespace UI
{
    public partial class Home_deposito : Form
    {
        public Home_deposito()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Home_deposito_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alta_producto formHijo = new alta_producto();
            formHijo.MdiParent = this;  // Configura el formulario padre
            formHijo.Show();
        }
    }
}
