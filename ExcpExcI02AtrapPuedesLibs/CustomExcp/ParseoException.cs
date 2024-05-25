using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcpExcI02AtrapPuedesLibs.CustomExcp
{
    public class ParseoException : Exception
    {
        public const string NOT_POSITIVE = "Error:Solo trabajo con numeros enteros positivos";

        public ParseoException(string mssg, Exception? exp):base(mssg,exp) { }
    }
}
