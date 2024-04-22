using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcA01Lib
{
    public class DriverManager
    {
        public Driver GetDriverMaxKmInWeek(Driver[] drivers) {
            Driver mxKmDriver = null;
            Driver driver = null;
            int mxKm = 0;
            int axKm = 0;

            for (int i = 0; i < drivers.Length; i++) { 
                driver = drivers[i];
                axKm = driver.GiveTheKmSumInWeek();

                if (axKm > mxKm) {
                    mxKm = axKm;
                    mxKmDriver = driver;
                }
            
            }

            return mxKmDriver;
        }

        //si hay mas de un conductor con el mismo Km en dia 3 me quedo con primera ocurrencia
        public Driver GetDriverMaxKmByDayNumber(Driver[] drivers, int day) {
            Driver mxKmDriver = null;
            Driver driver = null;
            int mxKm = 0;
            int axKm = 0;

            for (int i = 0; i < drivers.Length; i++){
                driver = drivers[i];
                axKm = driver.GetKmByWeekDay(day);

                if (axKm > mxKm) {
                    mxKm = axKm;
                    mxKmDriver = driver;
                }

            }

            return mxKmDriver;
        }
        
    }
}
