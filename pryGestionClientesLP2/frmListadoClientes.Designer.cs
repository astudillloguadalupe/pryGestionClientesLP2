namespace pryGestionClientesLP2
{
    partial class frmListadoClientes
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
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioRTA = new System.Windows.Forms.Label();
            this.lblTotalDeudaRTA = new System.Windows.Forms.Label();
            this.lblCantidadRTA = new System.Windows.Forms.Label();
            this.lblTotDeuda = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.lblPromedioRTA);
            this.grpConsultaDatos.Controls.Add(this.lblTotalDeudaRTA);
            this.grpConsultaDatos.Controls.Add(this.lblCantidadRTA);
            this.grpConsultaDatos.Controls.Add(this.lblTotDeuda);
            this.grpConsultaDatos.Controls.Add(this.lblCant);
            this.grpConsultaDatos.Controls.Add(this.lblPromedio);
            this.grpConsultaDatos.Controls.Add(this.dgvConsulta);
            this.grpConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(460, 470);
            this.grpConsultaDatos.TabIndex = 0;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de Datos ";
            //this.grpConsultaDatos.Enter += new System.EventHandler(this.grpConsultaDatos_Enter);
            // 
            // lblPromedioRTA
            // 
            this.lblPromedioRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioRTA.Location = new System.Drawing.Point(343, 444);
            this.lblPromedioRTA.Name = "lblPromedioRTA";
            this.lblPromedioRTA.Size = new System.Drawing.Size(100, 23);
            this.lblPromedioRTA.TabIndex = 6;
            // 
            // lblTotalDeudaRTA
            // 
            this.lblTotalDeudaRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaRTA.Location = new System.Drawing.Point(343, 366);
            this.lblTotalDeudaRTA.Name = "lblTotalDeudaRTA";
            this.lblTotalDeudaRTA.Size = new System.Drawing.Size(100, 23);
            this.lblTotalDeudaRTA.TabIndex = 5;
            // 
            // lblCantidadRTA
            // 
            this.lblCantidadRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadRTA.Location = new System.Drawing.Point(343, 405);
            this.lblCantidadRTA.Name = "lblCantidadRTA";
            this.lblCantidadRTA.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadRTA.TabIndex = 4;
            //this.lblCantidadRTA.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTotDeuda
            // 
            this.lblTotDeuda.AutoSize = true;
            this.lblTotDeuda.Location = new System.Drawing.Point(204, 366);
            this.lblTotDeuda.Name = "lblTotDeuda";
            this.lblTotDeuda.Size = new System.Drawing.Size(82, 13);
            this.lblTotDeuda.TabIndex = 3;
            this.lblTotDeuda.Text = "Total de deuda:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(204, 405);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(106, 13);
            this.lblCant.TabIndex = 2;
            this.lblCant.Text = "Cantidad de clientes:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(204, 447);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(102, 13);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio de deuda:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreApellido,
            this.Limite,
            this.deuda});
            this.dgvConsulta.Location = new System.Drawing.Point(6, 19);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(448, 328);
            this.dgvConsulta.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre y Apellido";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.ReadOnly = true;
            this.NombreApellido.Width = 140;
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Límite de credito";
            this.Limite.Name = "Limite";
            this.Limite.ReadOnly = true;
            // 
            // deuda
            // 
            this.deuda.HeaderText = "Deuda";
            this.deuda.Name = "deuda";
            this.deuda.ReadOnly = true;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 494);
            this.Controls.Add(this.grpConsultaDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPromedioRTA;
        private System.Windows.Forms.Label lblTotalDeudaRTA;
        private System.Windows.Forms.Label lblCantidadRTA;
        private System.Windows.Forms.Label lblTotDeuda;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuda;
    }
}