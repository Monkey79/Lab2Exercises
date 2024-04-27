using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHercExcI01
{
    public class Truck : Vehicle
    {
        private short gearCount; //cantidad marchas
        private short loadingWeight;

        public Truck(short numberOfWheels, short numberOfDoors, Colors color, short gearCount, short loadingWeight) : base(numberOfWheels, numberOfDoors, color){
            this.gearCount = gearCount;
            this.loadingWeight = loadingWeight;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"clase extendida camion.cant_marchas = {gearCount}, cantidad_peso={loadingWeight}");
            return sb.ToString();
        }

    }
}
