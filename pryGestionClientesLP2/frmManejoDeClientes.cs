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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmGestionClientes();
           
            formulario.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            precargarDatosClientes();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoClientes();
          
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void listadoClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoOrdenado();
            formulario.Show();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmClientesDeudores();
            formulario.Show();
                
        }

        public void precargarDatosClientes()
        {
            // Verifica que el índice sea 0 para no duplicar datos si el form se abre más de una vez
            if (Vectores.IND == 0)
            {
                Vectores.Clientes[Vectores.IND].Codigo = 50;
                Vectores.Clientes[Vectores.IND].Usuario = "Guada";
                Vectores.Clientes[Vectores.IND].Deuda = 17000;
                Vectores.Clientes[Vectores.IND].Limite = 10000;
                Vectores.IND++;

                Vectores.Clientes[Vectores.IND].Codigo = 30;
                Vectores.Clientes[Vectores.IND].Usuario = "Rafael";
                Vectores.Clientes[Vectores.IND].Deuda = 0;
                Vectores.Clientes[Vectores.IND].Limite = 90000;
                Vectores.IND++;

                Vectores.Clientes[Vectores.IND].Codigo = 20;
                Vectores.Clientes[Vectores.IND].Usuario = "Lautaro";
                Vectores.Clientes[Vectores.IND].Deuda = 5000;
                Vectores.Clientes[Vectores.IND].Limite = 70000;
                Vectores.IND++;
            }
        }

    }
}
