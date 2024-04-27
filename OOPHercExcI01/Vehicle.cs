using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHercExcI01
{
    public class Vehicle
    {
        private short numberOfWheels;
        private short numberOfDoors;
        private Colors color;

        public Vehicle(short numberOfWheels, short numberOfDoors, Colors color){
            this.numberOfWheels = numberOfWheels;
            this.numberOfDoors = numberOfDoors;
            this.color = color;
        }

        public short NumberOfWheels { get => numberOfWheels; set => numberOfWheels = value; }
        public short NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public Colors Color { get => color; set => color = value; }

        public void StartTheEngine() {
            Console.WriteLine("---brummm im a vehicle---");
        
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"clase base vehiculo.ruedad= {numberOfWheels}, puertas={numberOfDoors}, color={color}");
            return sb.ToString();
        }
    }
}
