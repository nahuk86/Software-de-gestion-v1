using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Forms_gerente;
using UI.Forms.Forms_vendedor;

namespace UI
{
    public partial class Home_gerente : Form
    {
        public Home_gerente()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void Home_gerente_Load(object sender, EventArgs e)
        {

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_crear_usuario formHijo = new form_crear_usuario();
            formHijo.MdiParent = this;  // Configura el formulario padre
            formHijo.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sesion.GetInstance.IsInRole(TipoPermiso.Asignar_rol_usuario))
            {
                frmPatenteFamilia frm = new frmPatenteFamilia();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("no tiene permisos");
            }
        }
    }
}
