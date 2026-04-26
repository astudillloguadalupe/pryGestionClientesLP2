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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vectores.IND < Vectores.Clientes.Length)
            {
                Int32 i = 0;
                Int32 codigoBuscado = Convert.ToInt32(txtCodigo.Text);

                while ((i < Vectores.IND && Vectores.Clientes[i].Codigo != codigoBuscado))
                {
                    i++;
                }
                if (i == Vectores.IND)
                {
                    Vectores.Clientes[Vectores.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vectores.Clientes[Vectores.IND].Usuario = txtUsuario.Text;
                    Vectores.Clientes[Vectores.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vectores.Clientes[Vectores.IND].Limite = Convert.ToInt32(txtLimite.Text);
                    Vectores.IND++;
                    
                    MessageBox.Show("Los datos se cargaron correctamente");
                    txtCodigo.Text = "";
                    txtDeuda.Text = "";
                    txtLimite.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    MessageBox.Show("El codigo ya existe, ingrese uno nuevo");
                    txtCodigo.Text = "";
                }

            }
            else
            {
                MessageBox.Show("No se pueden Cargar mas datos");
            }
          
        }


        private void comprobar()

        {
            
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;

            }
            else
            {
                btnCargar.Enabled=false;
            }
               
        }


        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;

        }

    
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

    
        private void btnDeudores_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
         
            comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }
    }
    
}
