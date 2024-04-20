using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjExcI01Libs
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad) {
            this.titular = titular;
            this.cantidad = cantidad;
        }


        public string Titular { get => titular; set => titular = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
