using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero1
{
    public class Cliente
    {
        public int NumeroCuenta;
        public string NombreCliente = "";
        public double Saldo;

        public int Numerocuenta
        {
            get { return NumeroCuenta; }
            set { NumeroCuenta = value; }

        }

        public string nombrecliente
        {
            get { return NombreCliente; }
            set { nombrecliente = value; }
        }

        

        public double saldo
        { get { return Saldo; } set { Saldo = value; } }
    }
}
