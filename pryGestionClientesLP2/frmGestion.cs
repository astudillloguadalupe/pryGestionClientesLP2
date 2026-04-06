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
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        //Declaracion de un Registro

        private struct RegCli
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;

        }

        //Declaracion del Vector
        private RegCli[] Clientes = new RegCli[10];

        //Declaracion del inidice
        private Int32 IND = 0;


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (IND < Clientes.Length)
            {

                Clientes[IND].Codigo = Convert.ToInt32(mtbCodigo.Text);
                Clientes[IND].Usuario = txtUsuario.Text;
                Clientes[IND].Deuda = Convert.ToDecimal(mtbDeuda.Text);
                Clientes[IND].Limite = Convert.ToInt32(mtbLimite.Text);
                IND++;
                MessageBox.Show("Los datos se cargaron correctamente");
                mtbCodigo.Text = "";
                mtbDeuda.Text = "";
                mtbLimite.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                MessageBox.Show("No se pueden Cargar mas datos");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)

        {
            Decimal Total = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < IND; i++)
            {
                dgvConsulta.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                Total = Total += Clientes[i].Deuda;
            }
            mtbTotal.Text = Total.ToString();
        }

        private void comprobar()
        {
            if (mtbCodigo.Text != ""&& mtbDeuda.Text != ""&& mtbLimite.Text !="")
            {
                btnCargar.Enabled = false;

            }
            else
            {
                btnCargar.Enabled=true;
            }
               
        }


        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            comprobar();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }

        private void mtbDeuda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            comprobar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void mtbLimite_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            comprobar();
        }
    }
}
