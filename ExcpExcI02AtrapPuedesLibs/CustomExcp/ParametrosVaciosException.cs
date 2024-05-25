using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcpExcI02AtrapPuedesLibs.CustomExcp
{
    public class ParametrosVaciosException : Exception
    {
        public const string EMPTY_MSSG = "Atencion: Debe completar los casillero de Kilombros y Litros";

        public ParametrosVaciosException(string mssg, Exception? exception) : base(mssg, exception) {

        }

    }
}
