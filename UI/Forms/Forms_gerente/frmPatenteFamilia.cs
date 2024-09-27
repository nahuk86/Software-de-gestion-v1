using ArqBase.BLL;
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

namespace UI.Forms.Forms_gerente
{
    public partial class frmPatenteFamilia : Form
    {
        PermisosServices repo;
        Familia seleccion;


        public frmPatenteFamilia()
        {
            InitializeComponent();
            repo = new PermisosServices();
            //cargo los permisos "Atómicos"
            this.cboPermisos.DataSource = repo.GetAllPermission();
        }

        private void LlenarPatentesFamilias()
        {

            this.cboPatentes.DataSource = repo.GetAllPatentes();
            this.cboFamilias.DataSource = repo.GetAllFamilias();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void treeConfigurarFamilia_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPatenteFamilia_Load(object sender, EventArgs e)
        {
            LlenarPatentesFamilias();

        }

        private void btnGuardarPatente_Click(object sender, EventArgs e)
        {
            Patente p = new Patente()
            {
                Nombre = this.txtNombrePatente.Text,
                Permiso = (TipoPermiso)this.cboPermisos.SelectedItem

            };

            repo.GuardarComponente(p, false);
            LlenarPatentesFamilias();

            MessageBox.Show("Patente guardada correctamente");
        }

        private void btnGuardarNombreFamilia_Click(object sender, EventArgs e)
        {
            Familia p = new Familia()
            {
                Nombre = this.txtNombreFamilia.Text

            };




            repo.GuardarComponente(p, true);
            LlenarPatentesFamilias();
            MessageBox.Show("Familia guardada correctamente");
        }

        void MostrarFamilia(bool init)
        {
            if (seleccion == null) return;


            IList<Componente> flia = null;
            if (init)
            {
                //traigo los hijos de la base
                flia = repo.GetAll("=" + seleccion.Id);


                foreach (var i in flia)
                    seleccion.AgregarHijo(i);
            }
            else
            {
                flia = seleccion.Hijos;
            }

            this.treeConfigurarFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            this.treeConfigurarFamilia.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigurarFamilia.ExpandAll();
        }

        void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {
                    MostrarEnTreeView(n, item);
                }

        }


        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = repo.Existe(seleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("ya exsite la patente indicada");
                    else
                    {

                        {
                            seleccion.AgregarHijo(patente);
                            MostrarFamilia(false);
                        }
                    }
                }
            }
        }

        private void btnConfigFamilia_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem;
            seleccion = new Familia();
            seleccion.Id = tmp.Id;
            seleccion.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var familia = (Familia)cboFamilias.SelectedItem;
                if (familia != null)
                {

                    var esta = repo.Existe(seleccion, familia.Id);
                    if (esta)
                        MessageBox.Show("ya exsite la familia indicada");
                    else
                    {

                        repo.FillFamilyComponents(familia);
                        seleccion.AgregarHijo(familia);
                        MostrarFamilia(false);
                    }


                }
            }
        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                repo.GuardarFamilia(seleccion);
                MessageBox.Show("Familia guardada correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar la familia");
            }
        }
    }
}
