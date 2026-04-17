using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGestionClientesLP2
{
    internal class Vectores

    {
        public struct RegClientes
        {
            public Int32 Codigo;
            public string Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        };

        //Declaración de un vector de tipo RegClientes
        static public RegClientes[] Clientes = new RegClientes[10];
        //Declaracion indice

        static public Int32 IND = 0;

        static public void precarga()
        {
            Clientes[IND].Codigo = 10;
            Clientes[IND].Nombre = "Guada";
            Clientes[IND].Deuda = 5000;
            Clientes[IND].Limite = 18000;
            IND++;
            Clientes[IND].Codigo = 30;
            Clientes[IND].Nombre = "Lauti";
            Clientes[IND].Deuda = 2000;
            Clientes[IND].Limite = 16000;
            IND++;
            Clientes[IND].Codigo = 60;
            Clientes[IND].Nombre = "Rafael";
            Clientes[IND].Deuda = 6000;
            Clientes[IND].Limite = 19000;
            IND++;

        }

        
        static public void OrdenarPorCodigoAscendente()
        {

            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;

            while (c < IND - 1)
            {
                i =0;
                
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo >  Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];//Llevo el registro completo con los 4 campos a variable auxiliar
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorCodigoDescendente()
        {

            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < IND - 1)
            {
         
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorNombreAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Nombre.CompareTo (Clientes[i + 1].Nombre) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorNombreDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Nombre.CompareTo(Clientes[i + 1].Nombre) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        private static object CompareTo(object value)
        {
            throw new NotImplementedException();
        }

        static public void OrdenarPorLimiteAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < IND - 1)
            {
        
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite.CompareTo(Clientes[i + 1].Limite) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorLimiteDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < IND - 1)
            {
                
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Limite.CompareTo(Clientes[i + 1].Limite) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        
        static public void OrdenarPorDeudaAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < IND - 1)
            {
            
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda.CompareTo(Clientes[i + 1].Deuda) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }


        static public void OrdenarPorDeudaDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda.CompareTo(Clientes[i + 1].Deuda) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
    }
}
