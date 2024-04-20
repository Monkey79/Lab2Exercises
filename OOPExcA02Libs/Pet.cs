using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcA02Libs
{
    public class Pet
    {
        private string species;
        private string name;
        private DateTime birthDate;

        private string[] vaccinations;

        public Pet(string species, string name, DateTime birthDate, string[] vaccinations) {
            this.species = species;
            this.name = name;
            this.birthDate = birthDate;
            this.vaccinations = vaccinations;
        }

        public string Species { get => species; set => species = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string[] Vaccinations { get => vaccinations; set => vaccinations = value; }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($" Mascota.nombre {name}");            
            stringBuilder.AppendLine($" Mascota.especie {species}");            
            stringBuilder.AppendLine($" Mascota.fecha_nacimiento {birthDate}");
            
            if(vaccinations != null  && vaccinations.Length > 0) {
                foreach (var item in vaccinations)
                {
                    stringBuilder.AppendLine($" Mascota.vacuna_nombre {item}");
                }
            }         
            return stringBuilder.ToString();
        }
    }
}
