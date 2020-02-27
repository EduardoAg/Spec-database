namespace Master_Database
{
    partial class frmUltimaFila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UltimaFila = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbListado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la hoja que contiene el listado materiales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el numero de la ultima fila utilizada en el listado:";
            // 
            // txt_UltimaFila
            // 
            this.txt_UltimaFila.Location = new System.Drawing.Point(381, 39);
            this.txt_UltimaFila.Name = "txt_UltimaFila";
            this.txt_UltimaFila.Size = new System.Drawing.Size(218, 22);
            this.txt_UltimaFila.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 67);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(289, 26);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(310, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(289, 26);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbListado
            // 
            this.cmbListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Location = new System.Drawing.Point(381, 9);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(218, 24);
            this.cmbListado.TabIndex = 6;
            // 
            // frmUltimaFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(611, 109);
            this.Controls.Add(this.cmbListado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txt_UltimaFila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUltimaFila";
            this.Text = "Importar listado de materiales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UltimaFila;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbListado;
    }
}