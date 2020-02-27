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
    public partial class frmEditorPermisos : Form
    {
        public bool Nuevo = false;
        public int IDRole = 0;
        public frmEditorPermisos()
        {
            InitializeComponent();
        }

        private void RolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rolesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rolesDataSet);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            try
            {
                this.permisosTableAdapter.Fill(this.permisosDataSet.permisos);
                if (Nuevo)
                {
                    this.rolesBindingSource.AddNew();

                    DataRowView linea = (DataRowView)this.rolesBindingSource.Current;
                    linea["nombre"] = "";

                    this.rolesBindingSource.EndEdit();
                }
                else
                {
                    this.rolesTableAdapter.FillByIDRole(this.rolesDataSet.roles, IDRole);
                    this.rolesPermisosTableAdapter.FillByIDRole(this.rolesDataSet.rolesPermisos, IDRole);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
                throw;
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            DataRowView PermisoSeleccionado = (DataRowView)this.permisosBindingSource.Current;
            bool Ya = false;
            foreach (DataRowView linea in rolesPermisosBindingSource) if ((int)linea["IDPermiso"] == (int)PermisoSeleccionado["IDPermiso"]) Ya = true;

            if (!Ya)
            {
                this.rolesBindingSource.EndEdit();
                this.rolesPermisosBindingSource.AddNew();
                DataRowView NuevoPermiso = (DataRowView)this.rolesPermisosBindingSource.Current;
                NuevoPermiso["IDPermiso"] = PermisoSeleccionado["IDPermiso"];
                NuevoPermiso["nombre"] = PermisoSeleccionado["nombre"];
                this.rolesPermisosBindingSource.EndEdit();
            }
        }

        private void Todosbutton_Click(object sender, EventArgs e)
        {
            foreach (DataRowView PermisoSeleccionado in permisosBindingSource)
            {
                bool Ya = false;
                foreach (DataRowView linea in rolesPermisosBindingSource) if ((int)linea["IDPermiso"] == (int)PermisoSeleccionado["IDPermiso"]) Ya = true;

                if (!Ya)
                {
                    this.rolesBindingSource.EndEdit();
                    this.rolesPermisosBindingSource.AddNew();
                    DataRowView NuevoPermiso = (DataRowView)this.rolesPermisosBindingSource.Current;
                    NuevoPermiso["IDPermiso"] = PermisoSeleccionado["IDPermiso"];
                    NuevoPermiso["nombre"] = PermisoSeleccionado["nombre"];
                    this.rolesPermisosBindingSource.EndEdit();
                }
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            this.rolesPermisosBindingSource.RemoveCurrent();
        }
    }
}
