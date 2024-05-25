using ExcpExcI02AtrapPuedesLibs.CustomExcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcpExcI02AtrapPuedesLibs
{
    public static class CustomParser
    {
        public static void ParseFromUnsignedStrToInt(string value, out int num) {
            StringBuilder sb = new StringBuilder();
            try {
                num = int.Parse(value);
                if (num < 0) {                  
                    sb.AppendLine(ParseoException.NOT_POSITIVE);
                    sb.AppendLine($"numero= {value}");
                    throw new FormatException(sb.ToString());
                }                
            }catch (FormatException e) {
                num = -1;
                throw new ParseoException(e.Message, e);                
            }            
        }
    }
}
