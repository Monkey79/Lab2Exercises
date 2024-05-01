using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerncExcC01Lib
{
    public class Coach : Person
    {
        private DateTime birthDate;

        public Coach(string name) : base(name) { 
        }
        public Coach(string name, DateTime birthDate) : base(name) { 
            this.birthDate = birthDate;
        }

        public static bool operator == (Coach coarchA, Coach coachB) { 
            bool rslt = coarchA.Dni.Equals(coachB.Dni) && coarchA.birthDate.Equals(coachB.birthDate);
            return rslt;        
        }
        public static bool operator !=(Coach coachA, Coach coachB) { 
            return !(coachA == coachB);        
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"director_tecnico.fech-nacimiento={birthDate}");
            return sb.ToString();
        }
    }
}
