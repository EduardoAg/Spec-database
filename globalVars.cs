using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Master_Database
{
    public static class globalVars
    {
        //Nombre de la tablas
        public static string tbl_main = "tblMateriales";
        public static string tbl_familias = "tblFamilias";
        public static string tbl_marcas = "tblMarcas";
        public static string tbl_configuraciones = "tblConfiguraciones";

        //El connection de la base de datos de prueba y local.
        //public static string nombreServidor = "DESKTOP-R1M83GC";
        //public static string nombreDB = "bdSpecs";
        //public static string user = "";
        //public static string password = "";
        //public static string connectionString = "Data Source = " + nombreServidor + "; Initial Catalog = " + nombreDB + "; Trusted_Connection = True";

        public static int IDUsuario;

        public enum Permisos
        {
            AgregarMateriales = 1,
            AgregarFamilias = 2,
            AgregarMarcas = 3,
            EditarMateriales = 4,
            EditarFamilia = 5,
            EditarMarcas = 6,
            EliminarMateriales = 7,
            EliminarFamilias = 8,
            EliminarMarcas = 9,
            AdministrarUsuarios = 10,
            AdministrarRoles = 11
        }

        public static bool TienePermiso(int IDUsuario, Permisos permisos)
        {
            try
            {
                UsuariosDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter = new UsuariosDataSetTableAdapters.usuariosTableAdapter();

                if (usuariosTableAdapter.TienePermiso(IDUsuario, (int)permisos) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        //El connection de produccion
        public static string nombreServidor = "PORTAL";
        public static string nombreDB = "bdSpecs";
        public static string user = "dbSpecs";
        public static string password = "dbSpecs01$";
        public static string connectionString = "Data Source = " + nombreServidor + "; Initial Catalog = " + nombreDB + "; User ID = " + user + "; Password = " + password;
    } 
}
