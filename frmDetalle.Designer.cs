namespace Master_Database
{
    partial class frmDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Resumen = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codsap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Resumen)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Resumen
            // 
            this.dg_Resumen.AllowUserToAddRows = false;
            this.dg_Resumen.AllowUserToDeleteRows = false;
            this.dg_Resumen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Resumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Resumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codsap,
            this.descripcion,
            this.catalogo,
            this.marca,
            this.familia,
            this.comentarios});
            this.dg_Resumen.Location = new System.Drawing.Point(12, 12);
            this.dg_Resumen.Name = "dg_Resumen";
            this.dg_Resumen.ReadOnly = true;
            this.dg_Resumen.RowHeadersVisible = false;
            this.dg_Resumen.RowHeadersWidth = 51;
            this.dg_Resumen.RowTemplate.Height = 24;
            this.dg_Resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Resumen.Size = new System.Drawing.Size(976, 536);
            this.dg_Resumen.TabIndex = 0;
            this.dg_Resumen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dg_Resumen_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codsap
            // 
            this.codsap.HeaderText = "SAP";
            this.codsap.MinimumWidth = 6;
            this.codsap.Name = "codsap";
            this.codsap.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // catalogo
            // 
            this.catalogo.HeaderText = "Catalogo";
            this.catalogo.MinimumWidth = 6;
            this.catalogo.Name = "catalogo";
            this.catalogo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // familia
            // 
            this.familia.HeaderText = "Familia";
            this.familia.MinimumWidth = 6;
            this.familia.Name = "familia";
            this.familia.ReadOnly = true;
            // 
            // comentarios
            // 
            this.comentarios.HeaderText = "Comentarios";
            this.comentarios.MinimumWidth = 6;
            this.comentarios.Name = "comentarios";
            this.comentarios.ReadOnly = true;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.dg_Resumen);
            this.Name = "frmDetalle";
            this.Text = "Materiales seleccionados";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Resumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Resumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsap;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarios;
    }
}