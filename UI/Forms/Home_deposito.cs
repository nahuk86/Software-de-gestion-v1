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
        public Panel panelContenedor { get; private set; }

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
            formHijo.MdiParent = this;  // Asignar MdiParent
            formHijo.Show();
        }

        public void CambiarFormulario(Form nuevoForm)
        {
            // Cerrar todos los formularios hijos
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configurar y abrir el nuevo formulario
            nuevoForm.MdiParent = this;
            nuevoForm.Show();
        }
    }
}
