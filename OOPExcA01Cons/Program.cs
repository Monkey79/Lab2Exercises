using OOPExcA01Lib;

namespace OOPExcA01Cons
{
    internal class Program
    {
        static DriverManager driverManager;
        static Driver[] drivers;
        static void Main(string[] args) {
            driverManager = new DriverManager();
            ChargeDrivers();
            Console.WriteLine("-------------------------------");
            GetAndShowMaxKmDriver();
            GetAndShowMaxKmDriverDay3();
            GetAndShowMaxKmDriverDay5();
            Console.WriteLine("-------------------------------");
        }

        static void ChargeDrivers() {
            drivers = new Driver[] {
                new Driver("juan", new int[] {100,200,300,0,500,0,100}),
                new Driver("pedro", new int[] {0,2200,300,252,500,0,100}),
                new Driver("noelia", new int[] {4440,2200,300,252,500,0,100})
            };
        }
        static void GetAndShowMaxKmDriver() {
            Driver mxKmDriver = driverManager.GetDriverMaxKmInWeek(drivers);
            Console.WriteLine($"  1-El conductor con mas km en la semana es {mxKmDriver.Name}");
        }
        static void GetAndShowMaxKmDriverDay3() {
            Driver mxKmDriver = driverManager.GetDriverMaxKmByDayNumber(drivers,3);
            Console.WriteLine($"  1-El conductor con mas km en el dia miercoles es {mxKmDriver.Name}");
        }
        static void GetAndShowMaxKmDriverDay5(){
            Driver mxKmDriver = driverManager.GetDriverMaxKmByDayNumber(drivers, 5);
            Console.WriteLine($"  1-El conductor con mas km en el dia viernes es {mxKmDriver.Name}");
        }
    }
}