
namespace EjemploGrupo1
{
    partial class FrmFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.DtgDatosAmostrar = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosAmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDatos
            // 
            this.TxtDatos.Location = new System.Drawing.Point(202, 55);
            this.TxtDatos.Name = "TxtDatos";
            this.TxtDatos.Size = new System.Drawing.Size(201, 20);
            this.TxtDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese  su dato :";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.Window;
            this.BtnRegistrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(236, 93);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(131, 26);
            this.BtnRegistrar.TabIndex = 2;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DtgDatosAmostrar
            // 
            this.DtgDatosAmostrar.AllowUserToAddRows = false;
            this.DtgDatosAmostrar.AllowUserToDeleteRows = false;
            this.DtgDatosAmostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDatosAmostrar.BackgroundColor = System.Drawing.Color.Gray;
            this.DtgDatosAmostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtgDatosAmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosAmostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datos});
            this.DtgDatosAmostrar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgDatosAmostrar.Location = new System.Drawing.Point(82, 157);
            this.DtgDatosAmostrar.Name = "DtgDatosAmostrar";
            this.DtgDatosAmostrar.ReadOnly = true;
            this.DtgDatosAmostrar.Size = new System.Drawing.Size(349, 150);
            this.DtgDatosAmostrar.TabIndex = 3;
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Datos Ingresados";
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            // 
            // FrmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.DtgDatosAmostrar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDatos);
            this.Name = "FrmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosAmostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridView DtgDatosAmostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
    }
}

