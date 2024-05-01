using CollectExcC01Lib;

namespace CollectExcC01Cons
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hello, World!");

            Test1_ATeamOfTwoPlayerTop_WithTwoPlayer_AndTryAddThirdPlayer();
            Test2_ATeamOfTwoPlayerTop_WithOnePlayer_AndTryAddSecondPlayer();
        }

        static void Test1_ATeamOfTwoPlayerTop_WithTwoPlayer_AndTryAddThirdPlayer()  {
            Console.WriteLine("----------Tests 1----------------------");
            Team team = new Team(2,"Equipo_A");

            team.Players.Add(new Player(565656, "pepe", 10, 100));
            team.Players.Add(new Player(787878, "omar", 10, 200));
            Console.WriteLine(team);

            //---New third Player
            Player newPlayer = new Player(898989, "paola", 2, 200);

            bool addSucess = team + newPlayer; //llamo operador sobrecargado +
            Console.WriteLine($"resultado sobrecarga operacion '+' {addSucess}");

            Console.WriteLine(team);
            Console.WriteLine("-----------------------------------------");
        }

        static void Test2_ATeamOfTwoPlayerTop_WithOnePlayer_AndTryAddSecondPlayer(){
            Console.WriteLine("----------Tests 2----------------------");
            Team team = new Team(2, "Equipo_B");

            team.Players.Add(new Player(565656, "pepe", 10, 100));
            Console.WriteLine(team);

            //---New second Player
            Player newPlayer = new Player(898989, "paola", 2, 200);
            bool addSucess = team + newPlayer; //llamo operador sobrecargado +

            Console.WriteLine($"resultado sobrecarga operacion '+' {addSucess}");
            Console.WriteLine(team);
            Console.WriteLine("-----------------------------------------");
        }
    }
}