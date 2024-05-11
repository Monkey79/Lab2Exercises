using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormExcC03UIBinLib
{
    public class DecimalNumber
    {
        private double number;

        private DecimalNumber(double number) {
            this.number = number;
        }

        public static double operator + (DecimalNumber dcNum, BinaryNumber bnNum) {
            int numPrs = 0;
            bool rslBl = int.TryParse(bnNum.Number, out numPrs); //convierto num binario string a int
            int dcConv;
            double fnRsl = 0;
            if (rslBl) {
                rslBl = int.TryParse(Converter.ConvertBinaryToDecimal(numPrs), out dcConv);
                if (rslBl) {
                    fnRsl = (double)(dcConv + dcNum.Number);
                }
            }
            return fnRsl;
        }
        public static double operator - (DecimalNumber dcNum, BinaryNumber bnNum) {
            int numPrs = 0;
            bool rslBl = int.TryParse(bnNum.Number, out numPrs); //convierto num binario string a int
            int dcConv;
            double fnRsl = 0;
            if (rslBl) {
                rslBl = int.TryParse(Converter.ConvertBinaryToDecimal(numPrs), out dcConv);
                if (rslBl) {
                    fnRsl = (double)(dcConv - dcNum.Number);
                    fnRsl *= (fnRsl < 0) ? -1 : 1;
                }
            }
            return fnRsl;
        }

        public static bool operator == (DecimalNumber dcNum, BinaryNumber bnNum) {
            string dcNumStr = dcNum.Number.ToString();
            return (dcNumStr.Equals(bnNum.Number));
        }
        public static bool operator != (DecimalNumber dcNum, BinaryNumber bnNum) {
            return !(dcNum == bnNum);
        }
        public double Number { get => number;}
    }
}
