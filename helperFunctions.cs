using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Ookii.Dialogs.WinForms;

namespace Master_Database
{
    class helperFunctions
    {
        //Regresa true si el string esta empty y muestra el mensaje, de lo contrario regresa false y no muestra mensaje
        public bool mensajeAdvEmpty(bool condicion, string mensaje)
        {
            if (condicion)
            {
                MessageBox.Show("Porfavor llenar el campo para " + mensaje);
                return condicion;
            }
            else
            {
                return condicion;
            }
        }
        //Regresa la clase keyBoolean que contiene dos propiedades: Un integer como valor para el key y un boolean como valor
        //En caso de que no se pueda hacer la conversion a integer entonces regresa (0, false) en caso contrario (numero, true)
        public keyBoolean mensajeAdvInt(string check, string mensaje)
        {
            keyBoolean vals = new keyBoolean();
            vals.key = 0;
            vals.boolean = false;
            int value; 
            if (int.TryParse(check, out value))
            {
                vals.key = value;
                vals.boolean = true;
            }
            else
            {
                MessageBox.Show("Ingresar un valor valido para " + mensaje);
            }
            return vals;
        }
        /// <summary>
        /// Verifica que el codiog sap sea un nombre pero si esta vacio lo deja pasar. En caso de que lo deje pasar entonces regresa (0, true) si esta
        /// vacio. Si no esta vacio regresa (numero, true). Si no lo deja pasar, es decir, no es un numero, regresa (0, false)
        /// </summary>
        /// <param name="check">El string que se trata de convertir a integer</param>
        /// <param name="mensaje">El mensaje a mostrar</param>
        /// <returns></returns>
        public keyBoolean mensajeAdvSap(string check, string mensaje)
        {
            keyBoolean vals = new keyBoolean();
            vals.key = 0;
            vals.boolean = false;
            int value;
            if (string.IsNullOrWhiteSpace(check))
            {
                vals.boolean = true;
            }
            else
            {
                if (int.TryParse(check, out value))
                {
                    vals.key = value;
                    vals.boolean = true;
                }
                else
                {
                    MessageBox.Show("Ingresar un valor valido para " + mensaje);
                }
            }
            
            return vals;
        }


        //Valida los comboboxes
        public keyValue validarCombos(ComboBox combo)
        {
            keyValue item = new keyValue();
            item.Value = 0;
            item.Text = "";
            if (!(string.IsNullOrWhiteSpace(combo.Text) || combo.SelectedIndex == -1))
            {
                item.Value = int.Parse(combo.SelectedValue.ToString());
                item.Text = combo.Text;
            }
            return item;
        }
        //Muestra un filepicker y guarda el path del archivo en una textbox
        public void mostrarFilePicker(TextBox txtBox)
        {
            OpenFileDialog filePick = new OpenFileDialog();
            filePick.ShowDialog();
            filePick.CheckFileExists = true;
            filePick.CheckPathExists = true;
            txtBox.Text = filePick.FileName;
        }
        //Verifica si tengo permisos para leer, borrar, y crear archivos en un directorio
        public bool IsDirectoryWritable(string dirPath)
        {
            try
            {
                using (FileStream fs = File.Create(Path.Combine(dirPath,Path.GetRandomFileName()),1,FileOptions.DeleteOnClose))
                {

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Valida el copiado y lo ejecuta. Si es null no ejecuta nada. Si no es null ejecuta el copiado del path existente al nuevo
        /// </summary>
        /// <param name="isNull">Si la textbox esta vacia</param>
        /// <param name="origen">El origen es el valor del origen de la textbox</param>
        /// <param name="direccion">El index de la list generada por buscarDirGuardado</param>
        /// <param name="id">El id del ultimo archivo recien agregado</param>
        public void validarCopiado(bool isNull, string origen, int direccion, int id)
        {
            if (isNull)
            {
                return;
            }
            else
            {
                sqlCommands sql = new sqlCommands();
                string direcciones = sql.buscarDirGuardado()[direccion];
                string nombreGuardado = Path.Combine(direcciones, id.ToString() + Path.GetExtension(origen));
                File.Copy(origen, nombreGuardado);
            }
        }

        /// <summary>
        /// Crea los folders donde se van a descargar las especificaciones. [0] - Indicador, [1] - Enercom, [2] - Catalogos, 
        /// [3] - Specs UL, [4] - Texto, [5] - Varias
        /// </summary>
        /// <returns>Regresa una lista con los directorios recien creados. El primer elemento de la lista es "1" o "0"
        /// si es "1" entonces la operacion fue exitosa, si es "0" no fue exitosa. Seria mejor crear una clase que guarde esta info
        /// pero ya no hay tiempo</returns>
        public List<string> createFolderStructure()
        {
            //Crea el folder picker 
            VistaFolderBrowserDialog folderPicker = new VistaFolderBrowserDialog();
            DialogResult result = folderPicker.ShowDialog();
            //La direcciones seleccionada del folder picker

            string dirGuardado = folderPicker.SelectedPath;
            //La lista donde se van a guardar los directorios recien creados
            List<string> directorios = new List<string>();
            //El default es que la operacion no fue exitosa
            directorios.Add("0");

            if(result == DialogResult.OK)
            {
                if (IsDirectoryWritable(dirGuardado))
                {

                    //Crea los directorios de las carpetas de guardado
                    string carpetaEnercom = Path.Combine(dirGuardado, "SPECS ENERCOM");
                    string carpetaCatalogos = Path.Combine(dirGuardado, "CATALOGOS");
                    string carpetaUl = Path.Combine(dirGuardado, "SPECS UL");
                    string carpetaTexto = Path.Combine(dirGuardado, "SPECS TEXTO");
                    string carpetaVarias = Path.Combine(dirGuardado, "SPECS VARIAS");

                    //Crea las carpetas
                    System.IO.Directory.CreateDirectory(carpetaEnercom);
                    System.IO.Directory.CreateDirectory(carpetaCatalogos);
                    System.IO.Directory.CreateDirectory(carpetaUl);
                    System.IO.Directory.CreateDirectory(carpetaTexto);
                    System.IO.Directory.CreateDirectory(carpetaVarias);

                    //Añade las carpetas al listados
                    directorios[0] = "1";
                    directorios.Add(carpetaEnercom);
                    directorios.Add(carpetaCatalogos);
                    directorios.Add(carpetaUl);
                    directorios.Add(carpetaTexto);
                    directorios.Add(carpetaVarias);

                    //Regresa el listado donde se guardaron las direcciones recien creadas
                    return directorios;
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al tratar de escribir en las direcciones de guardado de los archivos." +
                    "Asegurarse que el usuario tiene los permisos requeridos para escribir en la carpeta seleccionada.");
                    return directorios;
                }
            }
            else
            {
                return directorios;
            }
            

        }

        /// <summary>
        /// Descarga los archivos que estan en la listBox de seleccionados
        /// </summary>
        public void descargarArchivos(List<List<string>> nombreArchivos)
        {
            //Se crean las carpetas donde se va a guardar y se guardan las direcciones en una lista
            List<string> directoriosDestino = new List<string>();
            directoriosDestino = createFolderStructure();

            //Contador para mostrar al usuario cuantos archivos se descargaron.
            int counter = 0;
            //Si es true muestra los mensajes de advertencias cuando ocurren errores en el copiado. De lo contrario no las muestra
            bool advertencias = true;

            //Verifica que el creado de la estructura del folder fue exitosa. El primer elemento de la lista es "1" si la operacion fue
            //exitosa
            if (directoriosDestino[0] == "1")
            {
                //Fetches las direcciones de guardado de los archivos a copiar
                sqlCommands sql = new sqlCommands();
                List<string> directoriosOrigen = sql.buscarDirGuardado();


                for (int j = 0; j <= 4; j++)
                {
                    //Verifica que no esten vacia la listas de los nombres de los archivos
                    if (nombreArchivos[j].Count != 0)
                    {
                        //Itera por todos los archivos y los copia
                        for (int i = 0; i < nombreArchivos[j].Count; i++)
                        {
                            try
                            {
                                //El directorio del origen del archivo
                                string origen = Path.Combine(directoriosOrigen[j], nombreArchivos[j][i]);
                                string destino = Path.Combine(directoriosDestino[j + 1], nombreArchivos[j][i]);

                                File.Copy(origen, destino, true);
                                FileInfo fileInfo = new FileInfo(destino);
                                fileInfo.IsReadOnly = false;
                                counter = counter + 1;
                            }
                            catch
                            {
                                //Si las advertencias no han sido suprimidas. Se suprimen cuando el usuario presion que si en la MessageBox
                                if (advertencias)
                                {
                                    string message = "Ocurrio un error al momento de descargar el archivo: " + nombreArchivos[0][i] +
                                    ". Posiblemente causado porque el archivo no existe. ¿Le gustaria suprimir este mensaje en un futuro?";
                                    string title = "Error en la descarga de especificaciones";
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result = MessageBox.Show(message, title, buttons);

                                    if (result == DialogResult.Yes)
                                    {
                                        advertencias = false;
                                    }
                                }
                            }
                        }
                    }   
                }
                //Mensaje de finalizacion
                MessageBox.Show("Proceso finalizado satisfactoriamente. Se han descargado " + counter.ToString() + " archivos.");
            }
        }

        //Verificar que los 5 directorios de guardado de los paths son validos y se puede escribir en ellos
        public bool verifyDirectories()
        {
            
            try
            {
                sqlCommands sql = new sqlCommands();
                List<string> direcciones = sql.buscarDirGuardado();
                string dirEnercom = direcciones[0];
                string dirCatalogo = direcciones[1];
                string dirUL = direcciones[2];
                string dirTexto = direcciones[3];
                string dirVarias = direcciones[4];
                bool okEnercom = IsDirectoryWritable(dirEnercom);
                bool okCatalogo = IsDirectoryWritable(dirCatalogo);
                bool okUL = IsDirectoryWritable(dirUL);
                bool okTexto = IsDirectoryWritable(dirTexto);
                bool okVarias = IsDirectoryWritable(dirVarias);
                if (okEnercom && okCatalogo && okUL && okTexto && okVarias)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al tratar de escribir en las direcciones de guardado de los archivos." +
                "Asegurarse que el usuario tiene los permisos requeridos para escribir en las carpetas de guardado. Error:\n" +
                ex.ToString());
                return false;
            }
        }
        //Genera el nombre con el que se guardan los archivos
        public string nameGenerator(string familia, string marca, string tipo, string fileName)
        {
            string name = "";
            name = " - " + familia + " - " + marca + " - " + tipo + Path.GetExtension(fileName);
            return name;
        }
        //Regresa la descripcion tipica o un mensaje de advertencia si no se ha seleccionado la familia
        public string getDescTipica(ComboBox cmb_Familia)
        {
            string descTipica = "";
            helperFunctions help = new helperFunctions();
            //Extrae la informacion del combobox. El value y el text.
            keyValue dtFamilia = help.validarCombos(cmb_Familia);
            //Verifica que no sea null o whitespace y tira un mensaje de advertencia. 
            bool null_familia = string.IsNullOrWhiteSpace(dtFamilia.Text);
            if (help.mensajeAdvEmpty(null_familia, "la familia.")) { return descTipica; }
            //Corre el comando SQL que regresa la descripcion tipica de la familia
            sqlCommands sql = new sqlCommands();
            descTipica = sql.buscarDescTipica(dtFamilia.Value);
            return descTipica;
        }
        /// <summary>
        /// Abre los archivos, busca el directorio de guardado en la base de datos. Primero crea una carpeta en los temporary files dependiendo del tipo
        /// de archivo que es. Despues guarda en la carpeta correspondiente con la opcion deleteonclose. No se pueden abrir dos archivos con el mismo
        /// nombre al mismo tiempo.
        /// </summary>
        /// <param name="tipo">Indica si es specenercom, speccatalo. Integer de 0-4</param>
        /// <param name="nombreArchivo">Indice el nombre del archivo, si esta vacio no hace nada</param>
        public void openFiles(int tipo, string nombreArchivo)
        {
            if (!string.IsNullOrWhiteSpace(nombreArchivo))
            {
                sqlCommands sql = new sqlCommands();
                List<string> listado = sql.buscarDirGuardado();
                string dirGuardado = Path.Combine(listado[tipo], nombreArchivo);
                if (File.Exists(dirGuardado))
                {
                    //Crea un nombre de archivo con una terminacion criptografica y a la vez mantiene el ID al principio.  
                    string destination = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(nombreArchivo) + " - " + Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(nombreArchivo));
                    File.Copy(dirGuardado, destination, true);
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = destination;
                    proceso.Start();
                }
                else
                {
                    MessageBox.Show("El archivo que esta tratando de abrir no existe. Edite el material con un archivo asociado nuevo.");
                }
                
            }
        }
       
        /// <summary>
        /// Verifica si el texto contiene una pleca o una contrapleca. Estos caracteres pueden afectar el nombramiento de los archivos.
        /// Si contiene pleca tira un mensaje de advertencia.
        /// </summary>
        /// <param name="texto">El texto a revisar</param>
        /// <param name="texto">El texto que se muestra en el messagebox</param>
        /// <returns>Regresa true si el texto contiene pleca o contra pleca y false de lo contrario</returns>
        public bool mensajeAdvPleca(string texto, string mensaje)
        {
            if (texto.ToLower().IndexOf('/') != -1 || texto.ToLower().IndexOf('\\') != -1)
            {
                MessageBox.Show("El texto para la " + mensaje + " no puede contener plecas o contraplecas.");
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Determina si un DataGridView esta vacio
        /// </summary>
        /// <param name="dataGrid">DataGridView object que se va a revisar</param>
        /// <returns></returns>
        public bool isDataGridEmpty(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
