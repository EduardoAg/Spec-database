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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usuariosDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.usuariosDataSet.usuarios);

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            DataRowView Usuario = (DataRowView)this.usuariosBindingSource.Current;
            if (PasswordtextBox.Text == Usuario["Password"].ToString())
            {
                globalVars.IDUsuario = (int)Usuario["IDUsuario"];
                this.Visible = false;
                frmPrincipal principal = new frmPrincipal();
                principal.WindowState = FormWindowState.Maximized;
                principal.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Contraseña incorrecta");
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
