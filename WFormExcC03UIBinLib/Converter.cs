using System.Text;

namespace WFormExcC03UIBinLib
{
    public class Converter
    {
        private const int BIN = 2;

        public static string ConvertDecimalToBinary(int decNum) {
            StringBuilder sb = new StringBuilder();
            Stack<int> binStack = new Stack<int>();

            while (decNum >= BIN) {                
                binStack.Push(decNum % 2);
                decNum = decNum / 2;
            }
            binStack.Push(decNum);

            foreach (var item in binStack) {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        public static string ConvertBinaryToDecimal(int binNum) {
            double dcNum=0;
            string binNumStr = binNum.ToString();
            int exp = binNumStr.Length - 1;

            for (int i = 0;i<binNumStr.Length;i++) {
                if (binNumStr[i] == '1') {
                    dcNum += Math.Pow(2, exp);
                }
                exp--;
            }

            return dcNum.ToString();
        }

    }
}