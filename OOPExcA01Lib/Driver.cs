using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcA01Lib
{
    public class Driver
    {
        private String name;
        private int[] kmPerDays;

        public Driver(string name) {
            this.name = name;
            this.kmPerDays = new int[7];
        }

        public Driver(string name, int[] kmPerDays) {
            this.name = name;
            this.kmPerDays = kmPerDays;            
        }

        public string Name { get => name; set => name = value; }
        public int GetKmByWeekDay(int i) { 
            return kmPerDays[i-1];
        }
        public void SetKmByWeekDay(int i ,int km) { 
            kmPerDays[i-1] = km; 
        }

        public int GiveTheKmSumInWeek() {
            int kmSum = 0;
            foreach(int i in kmPerDays) {
                kmSum += i;
            }
            return kmSum;
        }
    }
}
