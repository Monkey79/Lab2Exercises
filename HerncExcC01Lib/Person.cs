using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerncExcC01Lib
{
    public class Person
    {
        private long dni;
        private string name;
               

        public Person(long dni, string name) {
            this.dni = dni;
            this.name = name;
        }
        public Person(string name):this(0,name) { 
            
        }

        public long Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"persona.nombre={name}-persona.dni={dni}");
            return stringBuilder.ToString();
        }
    }
}
