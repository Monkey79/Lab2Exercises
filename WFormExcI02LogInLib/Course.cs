using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormExcI02LogInLib
{
    public class Course
    {
        public static string C_SHARP = "csharp";
        public static string C_PLUS = "cplusplus";
        public static string J_SCRIPT = "javascript";

        private string name;
        private string description;

        public Course(string name, string description) {
            this.name = name;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($" -curso.nombre={name}");
            stringBuilder.AppendLine($" -curso.descripcion={description}");
            return stringBuilder.ToString();

        }
    }
}
