using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesLP2
{
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = -1;
            cmbModo.SelectedIndex = -1;
        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            cmbCampo.Items.Add("Còdigo");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Limite Crèdito");
            cmbCampo.Items.Add("Deuda");

            cmbModo.Items.Add("Ascendente");
            cmbModo.Items.Add("Descendente");
        }
    }
}
