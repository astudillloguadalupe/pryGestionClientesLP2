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


       
        private void grpConsultaDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        
            public void Listar()
            {
                int CantidadClientes = 0;
                Decimal TotalDeuda = 0;
                Decimal Promedio = 0;

                dgvConsulta.Rows.Clear();

                for (int i = 0; i < Vectores.IND; i++)
                {
                    if (Vectores.Clientes[i].Deuda > 0)
                    {
                     dgvConsulta.Rows.Add
                        
                      (
                        Vectores.Clientes[i].Codigo,
                        Vectores.Clientes[i].Usuario,
                        Vectores.Clientes[i].Limite,
                        Vectores.Clientes[i].Deuda
                      );


                    CantidadClientes++;
                    TotalDeuda += Vectores.Clientes[i].Deuda;
                        
                    }
                }

                if (CantidadClientes > 0)
                {
                    Promedio = TotalDeuda / CantidadClientes;
                }

                lblTotalDeudaRTA.Text = TotalDeuda.ToString("C");
                lblCantidadRTA.Text = CantidadClientes.ToString();
                lblPromedioRTA.Text = Promedio.ToString("C");
            }
        
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            Listar();

        }
    }
}
