using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHercExcI01
{
    public class Car : Vehicle
    {
        private short gearCount;//cantidad marchas
        private short passengers;

        public Car(short numberOfWheels, short numberOfDoors, Colors color, short gearCount,short passengers) : base(numberOfWheels, numberOfDoors, color) {
            this.gearCount = gearCount;
            this.passengers = passengers;
        }

        public short GearCount { get => gearCount; set => gearCount = value; }
        public short Passengers { get => passengers; set => passengers = value; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"clase extendida auto.cant_marchas = {gearCount}, cantidad_pasajeros={passengers}");
            return sb.ToString();
        }
    }
}
