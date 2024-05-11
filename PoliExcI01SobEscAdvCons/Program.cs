namespace PoliExcI01SobEscAdvCons
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Title = "Ejercicio Sobre-Sobrescrito";

            Sobrescrito objetoSobrescrito = new Sobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobreescritura con String: [deberia ser TRUE]=");
            Console.WriteLine(objetoSobrescrito.Equals(new Sobrescrito()) );

            Console.ReadKey();
        }
    }
}