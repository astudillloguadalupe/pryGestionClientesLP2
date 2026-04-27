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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        
      private void Listar()
      {
            int CantidadClientes = 0;
            decimal TotalDeuda = 0;
            decimal Promedio = 0;

            dgvConsulta.Rows.Clear();

            for (int i = 0; i < Vectores.IND; i++)
            {
                // Mostrar TODOS los clientes
                dgvConsulta.Rows.Add
                (
                    Vectores.Clientes[i].Codigo,
                    Vectores.Clientes[i].Usuario,
                    Vectores.Clientes[i].Limite,
                    Vectores.Clientes[i].Deuda
                );

                // Solo calcular para los que tienen deuda
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    CantidadClientes++;
                    TotalDeuda += Vectores.Clientes[i].Deuda;
                }
            }

            if (CantidadClientes > 0)
            {
                Promedio = TotalDeuda / CantidadClientes;
            }

            lblTotalDeudaRTA.Text = TotalDeuda.ToString();
            lblCantidadRTA.Text = CantidadClientes.ToString();
            lblPromedioRTA.Text = Promedio.ToString();
        }
        
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            Listar();

        }
    }
}
