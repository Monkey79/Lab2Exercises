using OOPExcA02Libs;

namespace OOPExcA02Cons
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            CustomerWithDogNotVacc();
            CustomerWithCatTripFelVacc();
            CustomerWithCatNotVaccAndDogRabiaVacc();
        }

        public static void CustomerWithDogNotVacc() {
            DateTime brthDt;
            DateTime.TryParseExact("09/12/2020","MM/dd/yyyy",null, System.Globalization.DateTimeStyles.None, out brthDt);

            Pet[] dogPets = new Pet[] { 
                new Pet("Dog","fido",brthDt,null)
            };
            Customer customer = new Customer("pavon 222","pablo","perez","4545454", dogPets);

            Console.WriteLine(customer);
            foreach (var pet in dogPets) { Console.WriteLine(pet); }            
        }

        public static void CustomerWithCatTripFelVacc() {
            DateTime brthDt;
            DateTime.TryParseExact("05/22/2013", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out brthDt);

            Pet[] catPets = new Pet[] {
                new Pet("Cat","michi",brthDt,new string[]{"triple felina"})
            };
            Customer customer = new Customer("sarmiento 222", "omar", "perez", "5656565", catPets);
            
            Console.WriteLine(customer);
            foreach (var pet in catPets) { Console.WriteLine(pet); }
        }

        public static void CustomerWithCatNotVaccAndDogRabiaVacc() {
            DateTime brthDt;
            DateTime.TryParseExact("06/12/2010", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out brthDt);
            DateTime nBbrthDt;
            DateTime.TryParseExact("05/14/2011", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out nBbrthDt);

            Pet[] pets = new Pet[] {
                new Pet("Cat","michi",brthDt,null),
                new Pet("Dog","pepe",nBbrthDt,new string[]{"rabia"}),
            };
            Customer customer = new Customer("san martin 222", "sofia", "bermudez", "5656565", pets);

            Console.WriteLine(customer);
            foreach (var pet in pets) { Console.WriteLine(pet); }
        }
    }
}