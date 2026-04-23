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

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
             switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorCodigoAscendente();
;                   }
                    else
                    {
                        Vectores.OrdenarPorCodigoDescendente();

                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorNombreAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarPorNombreDescendente();
                    }
                    break;
                case 2:

                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        Vectores.OrdenarPorLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorDeudaAscendente();
                    }
                    else
                    {
                       Vectores.OrdenarPorDeudaDescendente();
                    }
                    break;

            }
            dgvlistado.Rows.Clear();
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                dgvlistado.Rows.Add(Vectores.Clientes[i].Codigo, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].Limite, Vectores.Clientes[i].Deuda);
            }
            
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
