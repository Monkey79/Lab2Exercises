using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormExcC03UIBinLib
{
    public class BinaryNumber
    {
        private string number;

        private BinaryNumber(string number) {
            this.number = number;
        }        

        public static string operator + (BinaryNumber bnNm, DecimalNumber dcNum) {
            int numPrs = 0;
            bool rslBl = int.TryParse(bnNm.Number, out numPrs); //convierto num binario de string a int
            int dcConv;
            int fnRsl = 0;
            if (rslBl) {
                //convierto a num decimal el numero binario y luego intento parsear a decimal el resultado
                rslBl = int.TryParse(Converter.ConvertBinaryToDecimal(numPrs), out dcConv);                
                if (rslBl) {
                    fnRsl = (int)(dcConv + dcNum.Number);
                }
            }
            return Converter.ConvertDecimalToBinary(fnRsl);           
        }

        public static string operator - (BinaryNumber bnNm, DecimalNumber dcNum) {
            int numPrs = 0;
            bool rslBl = int.TryParse(bnNm.Number, out numPrs); //convierto num binario string a int
            int dcConv;
            int fnRsl = 0;
            if (rslBl) {
                rslBl = int.TryParse(Converter.ConvertBinaryToDecimal(numPrs), out dcConv);
                if (rslBl) {
                    fnRsl = (int)(dcConv - dcNum.Number);
                    fnRsl *= (fnRsl < 0) ? -1 : 1;
                }
            }
            return Converter.ConvertDecimalToBinary(fnRsl);                 
        }

        public static bool operator == (BinaryNumber bnNm, DecimalNumber dcNum) {
            string dcNumStr = dcNum.Number.ToString();     
            return (dcNumStr.Equals(bnNm.Number));
        }
        public static bool operator != (BinaryNumber bnNm, DecimalNumber dcNum) {
            return !(bnNm == dcNum);
        }

        public string Number { get => number; }
    }
}
