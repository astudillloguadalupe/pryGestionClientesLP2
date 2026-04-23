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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
           
            Vectores.precarga();
            
        }

        private void Listar()
        {
            Decimal Total = 0;
            int Cant = 0;
            Decimal promedio = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < Vectores.IND; i++)
                // Clientes con deuda
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    dgvConsulta.Rows.Add(
                    Vectores.Clientes[i].Codigo,
                    Vectores.Clientes[i].Usuario,
                    Vectores.Clientes[i].Deuda,
                    Vectores.Clientes[i].Limite);
                    Cant++;
                    Total = Total + Vectores.Clientes[i].Deuda;
                }
            if (Cant > 0)
            {
                promedio = Total / Cant;
            }
            lblTotalDeudaRTA.Text = Total.ToString();
            lblCantidadRTA.Text = Cant.ToString();
            lblPromedioRTA.Text = promedio.ToString();
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            
            Listar();

        }
    }
}
