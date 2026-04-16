namespace pryGestionClientesLP2
{
    partial class frmGestionClientes
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
            this.grbCarga = new System.Windows.Forms.GroupBox();
            this.mtbLimite = new System.Windows.Forms.MaskedTextBox();
            this.mtbDeuda = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.btnDeudores = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCarga.SuspendLayout();
            this.grbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCarga
            // 
            this.grbCarga.Controls.Add(this.mtbLimite);
            this.grbCarga.Controls.Add(this.mtbDeuda);
            this.grbCarga.Controls.Add(this.mtbCodigo);
            this.grbCarga.Controls.Add(this.txtUsuario);
            this.grbCarga.Controls.Add(this.btnCargar);
            this.grbCarga.Controls.Add(this.lblDeuda);
            this.grbCarga.Controls.Add(this.lblUsuario);
            this.grbCarga.Controls.Add(this.lblLimite);
            this.grbCarga.Controls.Add(this.lblCodigo);
            this.grbCarga.Location = new System.Drawing.Point(12, 12);
            this.grbCarga.Name = "grbCarga";
            this.grbCarga.Size = new System.Drawing.Size(470, 162);
            this.grbCarga.TabIndex = 0;
            this.grbCarga.TabStop = false;
            this.grbCarga.Text = "Carga de Clientes";
            // 
            // mtbLimite
            // 
            this.mtbLimite.Location = new System.Drawing.Point(341, 68);
            this.mtbLimite.Mask = "99999";
            this.mtbLimite.Name = "mtbLimite";
            this.mtbLimite.Size = new System.Drawing.Size(100, 20);
            this.mtbLimite.TabIndex = 13;
            this.mtbLimite.ValidatingType = typeof(int);
            this.mtbLimite.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbLimite_MaskInputRejected);
            // 
            // mtbDeuda
            // 
            this.mtbDeuda.Location = new System.Drawing.Point(88, 64);
            this.mtbDeuda.Mask = "99999999999999999";
            this.mtbDeuda.Name = "mtbDeuda";
            this.mtbDeuda.Size = new System.Drawing.Size(100, 20);
            this.mtbDeuda.TabIndex = 12;
            this.mtbDeuda.ValidatingType = typeof(int);
            this.mtbDeuda.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDeuda_MaskInputRejected);
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.Location = new System.Drawing.Point(88, 19);
            this.mtbCodigo.Mask = "99999";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(100, 20);
            this.mtbCodigo.TabIndex = 11;
            this.mtbCodigo.ValidatingType = typeof(int);
            this.mtbCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigo_MaskInputRejected);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(341, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Location = new System.Drawing.Point(333, 110);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 29);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(27, 71);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 4;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(279, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(248, 71);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(87, 13);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite de credito:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.dgvConsulta);
            this.grbConsulta.Location = new System.Drawing.Point(12, 195);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(470, 290);
            this.grbConsulta.TabIndex = 0;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta de datos";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.limite,
            this.Deuda});
            this.dgvConsulta.Location = new System.Drawing.Point(6, 19);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(458, 265);
            this.dgvConsulta.TabIndex = 7;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(291, 508);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total de Deuda:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(376, 532);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // mtbTotal
            // 
            this.mtbTotal.Location = new System.Drawing.Point(382, 501);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(100, 20);
            this.mtbTotal.TabIndex = 6;
            // 
            // btnDeudores
            // 
            this.btnDeudores.Location = new System.Drawing.Point(263, 532);
            this.btnDeudores.Name = "btnDeudores";
            this.btnDeudores.Size = new System.Drawing.Size(100, 23);
            this.btnDeudores.TabIndex = 14;
            this.btnDeudores.Text = "Listar Deudores";
            this.btnDeudores.UseVisualStyleBackColor = true;
            this.btnDeudores.Click += new System.EventHandler(this.btnDeudores_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // limite
            // 
            this.limite.HeaderText = "Limite de Credito";
            this.limite.Name = "limite";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 567);
            this.Controls.Add(this.btnDeudores);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.grbCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            this.grbCarga.ResumeLayout(false);
            this.grbCarga.PerformLayout();
            this.grbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCarga;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.MaskedTextBox mtbLimite;
        private System.Windows.Forms.MaskedTextBox mtbDeuda;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}

