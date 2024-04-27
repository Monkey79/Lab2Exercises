using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHercExcI01
{
    public class Bike : Vehicle
    {
        private short engineDisplacement; //cilindrada

        public Bike(short numberOfWheels, short numberOfDoors, Colors color, short engineDisplacement) : base(numberOfWheels, numberOfDoors, color)
        {
            this.engineDisplacement = engineDisplacement;
        }

        public short EngineDisplacement { get => engineDisplacement; set => engineDisplacement = value; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"clase extendida moto.cilindradas = {engineDisplacement}");
            return sb.ToString();
        }
    }
}
