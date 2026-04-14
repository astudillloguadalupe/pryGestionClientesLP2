namespace pryGestionClientesLP2
{
    partial class frmListadoOrdenado
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
            this.grpConultaDatos = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListarCrédito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConultaDatos
            // 
            this.grpConultaDatos.Controls.Add(this.btnListar);
            this.grpConultaDatos.Controls.Add(this.dgvlistado);
            this.grpConultaDatos.Controls.Add(this.lblCampo);
            this.grpConultaDatos.Controls.Add(this.lblModo);
            this.grpConultaDatos.Controls.Add(this.cmbModo);
            this.grpConultaDatos.Controls.Add(this.cmbCampo);
            this.grpConultaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpConultaDatos.Name = "grpConultaDatos";
            this.grpConultaDatos.Size = new System.Drawing.Size(581, 406);
            this.grpConultaDatos.TabIndex = 0;
            this.grpConultaDatos.TabStop = false;
            this.grpConultaDatos.Text = "Consulta Datos";
            this.grpConultaDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(486, 363);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(83, 28);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.ListarCrédito,
            this.Deuda});
            this.dgvlistado.Location = new System.Drawing.Point(12, 135);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(557, 204);
            this.dgvlistado.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(36, 63);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(76, 24);
            this.lblCampo.TabIndex = 2;
            this.lblCampo.Text = "Campo:";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(366, 63);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(64, 24);
            this.lblModo.TabIndex = 3;
            this.lblModo.Text = "Modo:";
            // 
            // cmbModo
            // 
            this.cmbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Location = new System.Drawing.Point(448, 63);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(121, 21);
            this.cmbModo.TabIndex = 4;
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(120, 63);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 5;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // ListarCrédito
            // 
            this.ListarCrédito.HeaderText = "Listar Crédito";
            this.ListarCrédito.Name = "ListarCrédito";
            this.ListarCrédito.Width = 125;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 125;
            // 
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 430);
            this.Controls.Add(this.grpConultaDatos);
            this.Name = "frmListadoOrdenado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ordenado";
            this.grpConultaDatos.ResumeLayout(false);
            this.grpConultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConultaDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListarCrédito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}