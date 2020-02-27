using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Database
{
    public partial class frmEditorRoles : Form
    {
        public frmEditorRoles()
        {
            InitializeComponent();
        }

        private void RolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rolesDataSet);

        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                this.rolesTableAdapter.Fill(this.rolesDataSet.roles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmEditorPermisos role = new frmEditorPermisos();
            role.Nuevo = true;
            role.IDRole = 0;
            role.ShowDialog();
            CargarDatos();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmEditorPermisos role = new frmEditorPermisos();
            DataRowView rol = (DataRowView)this.rolesBindingSource.Current;
            role.Nuevo = false;
            role.IDRole = (int)rol["IDRole"];
            role.ShowDialog();
            CargarDatos();
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void RolesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rolesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rolesDataSet);
                MessageBox.Show("Datos guardados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
