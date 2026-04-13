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
            public string Codigo;
            public string Nombre;
            public string Deuda;
            public string Limite;
        };

        //Declaración de un vector de tipo RegClientes
        static public RegClientes[] Clientes = new RegClientes[10];
        //Declaracion indice

        static public Int32 I = 0;

    }
}
