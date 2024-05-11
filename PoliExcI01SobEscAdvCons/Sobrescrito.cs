using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliExcI01SobEscAdvCons
{
    public class Sobrescrito
    {
        private string id;

        public Sobrescrito():this("dummy") { 

        }
        public Sobrescrito(string id) {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"¡Este es mi método ToString sobrescrito!(id=){id}");
            return stringBuilder.ToString();
        }
        public override bool Equals(object?  obj) {
            return (obj is Sobrescrito);
        }
        public override int GetHashCode() {
            return 1142510181;
        }
    }
}
