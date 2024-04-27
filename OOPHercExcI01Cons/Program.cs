using OOPHercExcI01;
using System.Diagnostics;

namespace OOPHercExcI01Cons
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello, World!");

            Test1_VehicleTruck();
            Tests2_VehicleTruckAndCar();
            Tests3_Vehicle2Cars();
        }

        static void Test1_VehicleTruck() {
            Vehicle truck = new Truck(6, 2, Colors.red, 5, 200);
            Console.WriteLine(truck.ToString());
            Console.WriteLine("-------------------------------------");
        }
        static void Tests2_VehicleTruckAndCar() {
            Vehicle truck = new Truck(6, 2, Colors.red, 5, 200);
            Vehicle car = new Car(4, 4, Colors.blue, 5, 6);
            Console.WriteLine(truck.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine("-------------------------------------");
        }
        static void Tests3_Vehicle2Cars() {
            Vehicle car = new Car(4, 4, Colors.blue, 5, 6);
            Console.WriteLine(car.ToString());
            car.StartTheEngine();   
            Car car2 = new Car(4,4,Colors.gray, 5,4);
            Console.WriteLine(car2.ToString());
            car2.StartTheEngine();
            Console.WriteLine("-------------------------------------");
        }
    }
}