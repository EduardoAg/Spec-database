using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.IO;

namespace Master_Database
{
    public class stringNull
    {
        public string name { get; set;}
        public DBNull valnull { get; set; }
    }

    class sqlCommands
    {
        //Method que agrega marcas a la tabla de marcas. Si la operacion es exitosa entonces regresa 1. De lo contrario regresa 0
        public int nuevaMarca(string marca)
        {
            int result = 0;
            try
            {
                //Crea una conexion
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //El comando SQL. El nombre de la tabla esta en la variable global tbl_main
                    string sqlInsertMain = "INSERT INTO " + globalVars.tbl_marcas + " (nombreMarca) VALUES (@marca)";
                    //Se abre la conexion.
                    conn.Open();
                    //Se crea el comando.
                    SqlCommand cmd_Add = new SqlCommand(sqlInsertMain, conn);
                    //Crea, valida, y añade el parametro al comando SQL 
                    validarParametrosStr("@marca", cmd_Add, false, marca);
                    //Se ejecuta el comando 
                    cmd_Add.ExecuteNonQuery();
                    result = 1;
                    return result;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        //Method que agrega una familia a la tabla de familias. Si la operacion es exitosa entonces regresa 1. De lo contrario regresa 0
        public int nuevaFamilia(string familia, string descripcion)
        {
            int result = 0;
            try
            {
                //Crea una conexion
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;

                    //El comando SQL. El nombre de la tabla esta en la variable global tbl_main
                    string sqlInsertMain = "INSERT INTO " + globalVars.tbl_familias + " (nombreFamilia, descripcionTipica) VALUES (@familia, @descripcion)";

                    //Se abre la conexion.
                    conn.Open();

                    //Se crea el comando.
                    SqlCommand cmd_Add = new SqlCommand(sqlInsertMain, conn);

                    //Crea, valida, y añade el parametro al comando SQL 
                    validarParametrosStr("@familia", cmd_Add, false, familia);
                    validarParametrosStr("@descripcion", cmd_Add, false, descripcion);

                    //Se ejecuta el comando 
                    cmd_Add.ExecuteNonQuery();
                    result = 1;
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        //Method que añade un nuevo material a la base de datos. Las listas estan definidas en frmNuevoMat.cs
        public int nuevoMaterial(List<string> strCampos, List<int> intCampos, List<bool> null_strCampos, List<bool> null_intCampos)
        {
            int result = 0;
            try
            {
                //Crea una conexion
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //El comando SQL. El nombre de la tabla esta en la variable global tbl_main
                    string sqlInsertMain = "INSERT INTO " + globalVars.tbl_main + " (catalogo, familia, descripcion, marca," +
                        " codsap, comentarios, specenercom, speccatalogo, specul, spectexto, specvarias) VALUES (@catalogo," +
                        " @familia, @descripcion, @marca, @codsap, @comentarios, @specenercom, @speccatalogo, @specul," +
                        " @spectexto, @specvarias)";
                    //Se abre la conexion.
                    conn.Open();
                    //Se crea el comando.
                    SqlCommand cmd_Add = new SqlCommand(sqlInsertMain, conn);
                    //Verifica si existe el codigo sap en la base de datos. Returns 1 si existe, 0 si no existe.
                    if(existeCodsap(conn, intCampos[2]) == 1 && intCampos[2] != 0)
                    {
                        MessageBox.Show("El codigo SAP ingresado ya existe en la base de datos, porfavor ingrese un codigo diferente.");
                        return result;
                    }

                    /*
                    Orden de los strCampos: catalogo, descripcion, comentarios, specenercom, speccatalogo, specul, 
                    spectexto, specvarias
                    Orden de los intCampos: idFamilia, idMarca, intCodigosap 
                    */
                    //Se crea, valida, y se añade el parametro al comando. Las direcciones se agregan con null inicialmente.
                    validarParametrosStr("@catalogo", cmd_Add, null_strCampos[0], strCampos[0]);
                    validarParametrosStr("@descripcion", cmd_Add, null_strCampos[1], strCampos[1]);
                    validarParametrosStr("@comentarios", cmd_Add, null_strCampos[2], strCampos[2]);
                    validarParametrosStr("@specenercom", cmd_Add, true, strCampos[3]);
                    validarParametrosStr("@speccatalogo", cmd_Add, true, strCampos[4]);
                    validarParametrosStr("@specul", cmd_Add, true, strCampos[5]);
                    validarParametrosStr("@spectexto", cmd_Add, true, strCampos[6]);
                    validarParametrosStr("@specvarias", cmd_Add, true, strCampos[7]);
                    validarParametrosInt("@familia", cmd_Add, null_intCampos[0], intCampos[0]);
                    validarParametrosInt("@marca", cmd_Add, null_intCampos[1], intCampos[1]);
                    validarParametrosIntCero("@codsap", cmd_Add, null_intCampos[2], intCampos[2]);
                    //Se verifica que se pueda escribir en los directorios de guardado
                    helperFunctions help = new helperFunctions();
                    bool writeable = help.verifyDirectories();
                    if (!writeable)
                    {
                        return result; 
                    }
                    //Se ejecuta el comando 
                    cmd_Add.ExecuteNonQuery();
                    //Se busca el id de la row que recien se agrego 
                    int lastid = getIdentity(conn, globalVars.tbl_main);
                    
                    //Se hace el copiado de los archivos, agrega el ID y la extension y verifica que el combobox no este vacio.
                    help.validarCopiado(null_strCampos[3], strCampos[3], 0, lastid);
                    help.validarCopiado(null_strCampos[4], strCampos[4], 1, lastid);
                    help.validarCopiado(null_strCampos[5], strCampos[5], 2, lastid);
                    help.validarCopiado(null_strCampos[6], strCampos[6], 3, lastid);
                    help.validarCopiado(null_strCampos[7], strCampos[7], 4, lastid);

                    //Se hace la actualizacion de la base de datos a los nuevos valores 
                    string updCommandString = "UPDATE " + globalVars.tbl_main + " SET specenercom = @specenercom, speccatalogo = @speccatalogo, specul = @specul, spectexto = @spectexto, specvarias = @specvarias WHERE IDMaterial = @IDMaterial";
                    SqlCommand updCmd = new SqlCommand(updCommandString, conn);
                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@IDMaterial";
                    id.Value = lastid;
                    updCmd.Parameters.Add(id);
                    validarParamentrosDir("@specenercom", updCmd, null_strCampos[3], strCampos[3], lastid);
                    validarParamentrosDir("@speccatalogo", updCmd, null_strCampos[4], strCampos[4], lastid);
                    validarParamentrosDir("@specul", updCmd, null_strCampos[5], strCampos[5], lastid);
                    validarParamentrosDir("@spectexto", updCmd, null_strCampos[6], strCampos[6], lastid);
                    validarParamentrosDir("@specvarias", updCmd, null_strCampos[7], strCampos[7], lastid);
                    updCmd.ExecuteNonQuery();
                    result = 1;
                    return result;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public int getIdentity(SqlConnection conn, string tableName)
        {
            int value = 0;
            string selectIdentity = "SELECT IDENT_CURRENT('" + tableName + "')";
            SqlCommand command = new SqlCommand(selectIdentity, conn);
            value = int.Parse(command.ExecuteScalar().ToString());
            return value; 
        }

        //Metodo que llena los listboxes de las marcas y familias
        public void llenarMarcasFamilias(ComboBox listFamilias, ComboBox listMarcas)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //Selecciona los datos de las marcas y familias
                    string sqlGetMarcas = "SELECT * FROM " + globalVars.tbl_marcas + " ORDER BY nombreMarca ASC";
                    string sqlGetFamilias = "SELECT * FROM " + globalVars.tbl_familias + " ORDER BY nombreFamilia ASC";
                    //Se abre la conexion.
                    conn.Open();
                    //Crea un adaptador
                    SqlDataAdapter adpMarca = new SqlDataAdapter(sqlGetMarcas, conn);
                    SqlDataAdapter adpFamilia = new SqlDataAdapter(sqlGetFamilias, conn);
                    //Mapea las tablas source con las tablas de dataSet
                    DataTableMapping mapMarca = new DataTableMapping(globalVars.tbl_marcas, "dsMarca");
                    DataTableMapping mapFamilia = new DataTableMapping(globalVars.tbl_familias, "dsFamilia");
                    //Se crea un nuevo data set
                    DataSet ds = new DataSet();
                    //Se agrega el mapeo a los adaptadores
                    adpMarca.TableMappings.Add(mapMarca);
                    adpFamilia.TableMappings.Add(mapFamilia);
                    //Se agregan los adaptadores al dataset
                    adpMarca.Fill(ds, "dsMarca");
                    adpFamilia.Fill(ds, "dsFamilia");
                    //Se agrega el datasource a las combobox. Se pone el texto como nombre y el ID como el value.
                    listMarcas.DataSource = ds.Tables["dsMarca"];
                    listFamilias.DataSource = ds.Tables["dsFamilia"];
                    listMarcas.DisplayMember = "nombreMarca";
                    listFamilias.DisplayMember = "nombreFamilia";
                    listMarcas.ValueMember = "IDMarca";
                    listFamilias.ValueMember = "IDFamilia";
                    //Se cambia el selected index a -1 porque al agregar el datasource selecciona la primera por default.
                    listMarcas.SelectedIndex = -1;
                    listFamilias.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Agrega todas las marcas y todas las familias a los checked list boxes que aparecen al costado de la frmPrincipal
        /// </summary>
        /// <param name="listFamilias">El checked listBox de familias</param>
        /// <param name="listMarcas">El checked listBox de marcas</param>
        public void llenarListBoxMarcasFamilias(CheckedListBox listFamilias, CheckedListBox listMarcas)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //Selecciona los datos de las marcas y familias
                    string sqlGetMarcas = "SELECT * FROM " + globalVars.tbl_marcas + " ORDER BY nombreMarca ASC";
                    string sqlGetFamilias = "SELECT * FROM " + globalVars.tbl_familias + " ORDER BY nombreFamilia ASC";
                    //Se abre la conexion.
                    conn.Open();
                    //Crea un adaptador
                    SqlDataAdapter adpMarca = new SqlDataAdapter(sqlGetMarcas, conn);
                    SqlDataAdapter adpFamilia = new SqlDataAdapter(sqlGetFamilias, conn);
                    //Mapea las tablas source con las tablas de dataSet
                    DataTableMapping mapMarca = new DataTableMapping(globalVars.tbl_marcas, "dsMarca");
                    DataTableMapping mapFamilia = new DataTableMapping(globalVars.tbl_familias, "dsFamilia");
                    //Se crea un nuevo data set
                    DataSet ds = new DataSet();
                    //Se agrega el mapeo a los adaptadores
                    adpMarca.TableMappings.Add(mapMarca);
                    adpFamilia.TableMappings.Add(mapFamilia);
                    //Se agregan los adaptadores al dataset
                    adpMarca.Fill(ds, "dsMarca");
                    adpFamilia.Fill(ds, "dsFamilia");
                    //Se agrega el datasource a las combobox. Se pone el texto como nombre y el ID como el value.
                    listMarcas.DataSource = ds.Tables["dsMarca"];
                    listFamilias.DataSource = ds.Tables["dsFamilia"];
                    listMarcas.DisplayMember = "nombreMarca";
                    listFamilias.DisplayMember = "nombreFamilia";
                    listMarcas.ValueMember = "IDMarca";
                    listFamilias.ValueMember = "IDFamilia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Metodo para agregar null a la base de datos si el string esta vacio
        private void validarParametrosStr(string paramName, SqlCommand command, bool isNull, string paramValue)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = paramName;
            if (isNull)
            {
                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = paramValue;
            }
            command.Parameters.Add(param);
        }
        //Metodo para validar los file paths 
        private void validarParamentrosDir(string paramName, SqlCommand command, bool isNull, string origen, int id)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = paramName;
            if (isNull)
            {
                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = id.ToString() + Path.GetExtension(origen);
            }
            command.Parameters.Add(param);
        }
        //Metodo para agregar null a la base de dato si el int esta vacio. En teoria nunca esta vacio. 
        private void validarParametrosInt(string paramName, SqlCommand command, bool isNull, int paramValue)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = paramName;
            if (isNull)
            {
                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = paramValue;
            }
            command.Parameters.Add(param);
        }
        //Metodo para agregar null a la base de dato si el int esta vacio o es 0. Se utiliza para el codigo SAP 
        private void validarParametrosIntCero(string paramName, SqlCommand command, bool isNull, int paramValue)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = paramName;
            if (isNull || paramValue == 0)
            {
                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = paramValue;
            }
            command.Parameters.Add(param);
        }

        //Metodo para verificar si existe el codigo SAP 
        private int existeCodsap(SqlConnection conn, int codsap)
        {
            SqlCommand cmd = new SqlCommand("stpExiste_codsap", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter paramIn = new SqlParameter("@codsap", codsap);
            SqlParameter paramOut = new SqlParameter("@existe", System.Data.SqlDbType.Int);
            cmd.Parameters.Add(paramIn);
            cmd.Parameters.Add(paramOut).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int value = Convert.ToInt32(cmd.Parameters["@existe"].Value);
            return value;
        }


        //Metodo para buscar la descripcion tipica de las familias.
        public string buscarDescTipica(int idFamilia)
        {
            string valor = "Error";
            try
            {
                //Crea la conexion 
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //Se crea el comando sql y se añade el parametro 
                    string sqlSelectStatement = "SELECT descripcionTipica FROM " + globalVars.tbl_familias + " WHERE IDFamilia = @IDFamilia";
                    SqlCommand cmdSelect = new SqlCommand(sqlSelectStatement, conn);
                    SqlParameter paramFamilia = new SqlParameter();
                    paramFamilia.ParameterName = "@IDFamilia";
                    paramFamilia.Value = idFamilia;
                    cmdSelect.Parameters.Add(paramFamilia);
                    conn.Open();
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())

                    {     
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                valor = reader.GetString(reader.GetOrdinal("descripcionTipica"));
                            }   
                        }
                    }
                    return valor;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return valor;
            }
        }
        //Metodo para extraer la direccion de guardado de los files. Regresa un List con las 5 direcciones.
        /// <summary>
        /// 1 - Direccion ENERCOM
        /// 2 - Direccion Catalogo
        /// 3 - Direccion UL
        /// 4 - Direccion texto 
        /// 5 - Direccion varias
        /// </summary>
        /// <returns></returns>
        public List<string> buscarDirGuardado()
        {
            List<string> direcciones = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //La conection string esta definida en el archivo globalVars.cs
                    conn.ConnectionString = globalVars.connectionString;
                    //Se crea el comando sql y se añade el parametro 
                    string sqlSelectStatement = "SELECT * FROM " + globalVars.tbl_configuraciones + " ORDER BY idConfiguracion ASC";
                    SqlCommand cmdSelect = new SqlCommand(sqlSelectStatement, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                direcciones.Add(reader.GetString(reader.GetOrdinal("valor")));
                            }
                        }
                    }
                    return direcciones;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return direcciones;
            }
        }
        /// <summary>
        /// Busca la base de datos usando la descripcion el stp del fuzzy string match
        /// </summary>
        /// <param name="buscar">El parametro a buscar en la descripcion</param>
        /// <param name="dataGrid">El dataGrid donde se agregaran los valores</param>
        public void buscarDB(string buscar, DataGridView dataGrid)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = globalVars.connectionString;
                SqlCommand cmd = new SqlCommand("stpget_FuzzyResults", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramIn = new SqlParameter("@lookup", buscar);
                cmd.Parameters.Add(paramIn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = dt;

                dataGrid.Columns[0].DataPropertyName = "score";
                dataGrid.Columns[1].DataPropertyName = "IDMaterial";
                dataGrid.Columns[2].DataPropertyName = "codsap";
                dataGrid.Columns[3].DataPropertyName = "catalogo";
                dataGrid.Columns[4].DataPropertyName = "descripcion";
                dataGrid.Columns[5].DataPropertyName = "nombreMarca";
                dataGrid.Columns[6].DataPropertyName = "nombreFamilia";
            }
        }

        public void buscarDBFiltrado(string buscar, List<long> familias, List<long> marcas, DataGridView dataGrid)
        {
            //Crea la conexion
            using (SqlConnection conn = new SqlConnection())
            {
                //Connection string
                conn.ConnectionString = globalVars.connectionString;
                //Hace referencia al comando SQL
                SqlCommand cmd = new SqlCommand("stpget_FuzzyResultsFiltrado", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //El primer parametro del stp
                SqlParameter paramIn = new SqlParameter("@lookup", buscar);
                cmd.Parameters.Add(paramIn);
                //Crea el segundo parametro en base a las familias y marcas que estan seleccionadas 
                string whereClause = ""; 
                for(int i = 0; i < familias.Count; i++)
                {
                    long idFamilia = familias[i];
                    if (i == 0)
                    {
                        whereClause = "WHERE familia = " + idFamilia.ToString();
                    }
                    else
                    {
                        whereClause = whereClause + " AND familia = " + idFamilia.ToString();
                    }
                }
                for (int i = 0; i < marcas.Count; i++)
                {
                    long idMarca = marcas[i];
                    if (i == 0 && whereClause == "")
                    {
                        whereClause = "WHERE marca = " + idMarca.ToString();
                    }
                    else
                    {
                        whereClause = whereClause + " AND marca = " + idMarca.ToString();
                    }
                }
               
                SqlParameter paramClause = new SqlParameter("@whereclause", whereClause);
                cmd.Parameters.Add(paramClause);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = dt;

                dataGrid.Columns[0].DataPropertyName = "score";
                dataGrid.Columns[1].DataPropertyName = "IDMaterial";
                dataGrid.Columns[2].DataPropertyName = "codsap";
                dataGrid.Columns[3].DataPropertyName = "catalogo";
                dataGrid.Columns[4].DataPropertyName = "descripcion";
                dataGrid.Columns[5].DataPropertyName = "nombreMarca";
                dataGrid.Columns[6].DataPropertyName = "nombreFamilia";
            }
        }
        /// <summary>
        /// Busca la base de datos utilizando el catalogo. Es el mismo algoritmo fuzzy search de la descripcion pero aplicada al catalogo
        /// </summary>
        /// <param name="buscar">La string a buscar</param>
        /// <param name="dataGrid">El dataGridView donde se muestran los resultados</param>
        public void buscarDBPorCatalogo(string buscar, DataGridView dataGrid)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = globalVars.connectionString;
                SqlCommand cmd = new SqlCommand("stpget_FuzzyResultsCatalogo", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramIn = new SqlParameter("@lookup", buscar);
                cmd.Parameters.Add(paramIn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = dt;

                dataGrid.Columns[0].DataPropertyName = "score";
                dataGrid.Columns[1].DataPropertyName = "IDMaterial";
                dataGrid.Columns[2].DataPropertyName = "codsap";
                dataGrid.Columns[3].DataPropertyName = "catalogo";
                dataGrid.Columns[4].DataPropertyName = "descripcion";
                dataGrid.Columns[5].DataPropertyName = "nombreMarca";
                dataGrid.Columns[6].DataPropertyName = "nombreFamilia";
            }
        }
        /// <summary>
        /// Busca en base al ID. Crea el comando SQL dinamicamente basado en el numero de IDs. Agrega los resultados al dataGrid de los 
        /// items seleccionados.
        /// </summary>
        /// <param name="dataGridSelec">El dataGridView de los materiales seleccionados</param>
        /// /// <param name="dataGridRes">El dataGridView del resumen de materiales</param>
        /// <returns></returns>
        public void buscarMultipleID(DataGridView dataGridSelec, DataGridView dataGridRes)
        {
            //El comando SQL se llena la condicion con la loop de abajo
            string select = "SELECT * FROM tblMateriales INNER JOIN tblMarcas ON marca = IDMarca INNER JOIN tblFamilias ON familia = IDFamilia WHERE IDmaterial =";
            string condicion = "";
            //Itera por cada uno de los rows del DataGridView y crea la condicion del SQL dinamicamente
            foreach (DataGridViewRow item in dataGridSelec.Rows)
            {
                if (item.Index != 0)
                {
                    condicion = condicion + " OR IDmaterial = " + item.Cells[0].Value.ToString();
                }
                else if (item.Index == 0)
                {
                    condicion = " " + item.Cells[0].Value.ToString();
                }
            }
            select = select + condicion;
            //Crea la conexion y ejecuta el comando SQL 
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = globalVars.connectionString;
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            long ID = reader.GetInt64(reader.GetOrdinal("IDmaterial"));
                            string SAP = safeBigInt(reader, "codsap").ToString("D7");
                            string descripcion = safeString(reader ,"descripcion");
                            string catalogo = safeString(reader, "catalogo");
                            string marca = safeString(reader, "nombreMarca");
                            string familia = safeString(reader, "nombreFamilia");
                            string comentarios = safeString(reader, "comentarios");
                            dataGridRes.Rows.Add(ID, SAP, descripcion, catalogo, marca, familia, comentarios);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Busca en base al ID. Crea el comando SQL dinamicamente basado en el numero de IDs. Guarda los nombres de los archivos asociados
        /// en listas y tambien guarda en una lista si el archivo asociado existia o no existia
        /// </summary>
        /// <param name="dataGridSelec">El dataGridView de los materiales seleccionados</param>
        /// <returns></returns>
        public List<List<string>> buscarDirectoriosID(DataGridView dataGridSelec)
        {

            //Crea la lista que se va a regresar, la lista contiene 5 listas. Cada lista contiene los siguientes nombres:
            //1.specenercom
            //2.speccatalogo
            //3.specul
            //4.spectexto
            //5.specvarias
            List<List<string>> returnList = new List<List<string>>();
            //La lista de las specs enercom
            List<string> lst_dirEnercom = new List<string>();
            //La lista de las direcciones catalogo
            List<string> lst_dirCatalogo = new List<string>();
            //La lista de las direcciones ul
            List<string> lst_dirUl = new List<string>();
            //La lista de las specs texto
            List<string> lst_dirTexto = new List<string>();
            //La lista de las specs varias
            List<string> lst_dirVarias = new List<string>();

            //El comando SQL se llena la condicion con la loop de abajo
            string select = "SELECT * FROM tblMateriales INNER JOIN tblMarcas ON marca = IDMarca INNER JOIN tblFamilias ON familia = IDFamilia WHERE IDmaterial =";
            string condicion = "";
            //Itera por cada uno de los rows del DataGridView y crea la condicion del SQL dinamicamente
            foreach (DataGridViewRow item in dataGridSelec.Rows)
            {
                if (item.Index != 0)
                {
                    condicion = condicion + " OR IDmaterial = " + item.Cells[0].Value.ToString();
                }
                else if (item.Index == 0)
                {
                    condicion = " " + item.Cells[0].Value.ToString();
                }
            }
            select = select + condicion;
            try
            {
                //Crea la conexion y ejecuta el comando SQL 
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = globalVars.connectionString;
                    SqlCommand cmd = new SqlCommand(select, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //Se definen todas las direcciones, el safeString maneja los DBNulls
                                string dirEnercom = safeString(reader, "specenercom");
                                string dirCatalogo = safeString(reader, "speccatalogo");
                                string dirUl = safeString(reader, "specul");
                                string dirTexto = safeString(reader, "spectexto");
                                string dirVarias = safeString(reader, "specvarias");

                                //Si el string no es empty entonces lo agrega a la lista correspondiente
                                if (dirEnercom != "")
                                {
                                    lst_dirEnercom.Add(dirEnercom);
                                }
                                if (dirCatalogo != "")
                                {
                                    lst_dirCatalogo.Add(dirCatalogo);
                                }
                                if (dirUl != "")
                                {
                                    lst_dirUl.Add(dirUl);
                                }
                                if (dirTexto != "")
                                {
                                    lst_dirTexto.Add(dirTexto);
                                }
                                if (dirVarias != "")
                                {
                                    lst_dirVarias.Add(dirVarias);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return returnList;
            }
            

            //Agrega todas las listas a la lista que se va a retornar. Algunas pueden estar vacias, el check se hace cuando se utiliza
            returnList.Add(lst_dirEnercom);
            returnList.Add(lst_dirCatalogo);
            returnList.Add(lst_dirUl);
            returnList.Add(lst_dirTexto);
            returnList.Add(lst_dirVarias);

            //Regresa la lista que contiene todas las otras listas.
            return returnList;
        }

        /// <summary>
        /// Busca la base de datos por id y guarda los datos en una clase que contiene todos los datos
        /// </summary>
        /// <param name="id">El id que esta siendo buscado</param>
        /// <returns></returns>
        public clsMaterial buscarID(long id)
        {
            clsMaterial material = new clsMaterial();
            material.id = id;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = globalVars.connectionString;
                SqlCommand cmd = new SqlCommand("stp_getByID", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramIn = new SqlParameter("@id", id);
                cmd.Parameters.Add(paramIn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            material.catalogo = safeString(reader, "catalogo");
                            material.familia = safeString(reader, "nombreFamilia");
                            material.descripcion = safeString(reader, "descripcion");
                            material.marca = safeString(reader, "nombreMarca");
                            material.codsap = safeBigInt(reader, "codsap");
                            material.comentario = safeString(reader, "comentarios");
                            material.specenercom = safeString(reader, "specenercom");
                            material.speccatalogo = safeString(reader, "speccatalogo");
                            material.specul = safeString(reader, "specul");
                            material.spectexto = safeString(reader, "spectexto");
                            material.specvarias = safeString(reader, "specvarias");
                        }
                    }
                    return material;
                }
            }
        }
        /// <summary>
        /// Busca la base de datos por codigo SAP y guarda los datos en una clase que contiene todos los datos
        /// </summary>
        /// <param name="codsap">El codigo sap que esta siendo buscado</param>
        /// <returns></returns>
        public clsMaterial buscarPorCodigoSAP(long codsap)
        {
            clsMaterial material = new clsMaterial();
            material.codsap = codsap;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = globalVars.connectionString;
                SqlCommand cmd = new SqlCommand("stp_getBySAP", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramIn = new SqlParameter("@sap", codsap);
                cmd.Parameters.Add(paramIn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            material.id = safeBigInt(reader, "IDmaterial");
                            material.catalogo = safeString(reader, "catalogo");
                            material.familia = safeString(reader, "nombreFamilia");
                            material.descripcion = safeString(reader, "descripcion");
                            material.marca = safeString(reader, "nombreMarca");
                            material.comentario = safeString(reader, "comentarios");
                            material.specenercom = safeString(reader, "specenercom");
                            material.speccatalogo = safeString(reader, "speccatalogo");
                            material.specul = safeString(reader, "specul");
                            material.spectexto = safeString(reader, "spectexto");
                            material.specvarias = safeString(reader, "specvarias");
                        }
                    }
                    return material;
                }
            }
        }

        //Maneja valores nulls para strings
        public string safeString(SqlDataReader reader, string colName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(colName)))
            {
                return reader.GetString(reader.GetOrdinal(colName));
            }
            return "";
        }

        //Maneja valores nulls para strings
        public long safeBigInt(SqlDataReader reader, string colName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(colName)))
            {
                return reader.GetInt64(reader.GetOrdinal(colName));
            }
            return 0;
        }

    }
}
