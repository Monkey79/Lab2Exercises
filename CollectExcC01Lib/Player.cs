using System.Security.AccessControl;
using System.Text;

namespace CollectExcC01Lib
{
    public class Player
    {
        private int dni;
        private string name;

        private int gamesPlayed;      
        private int totalGoals; 

        //NOTA: Salvo patron Singletone NUNCA se llamaria a este CONST desde fuera ?
        private Player() :this(0,"",0,0) { 
        
        }

        public Player(int dni, string name):this(dni,name,0,0) {
            
        }

        public Player(int dni, string name, int gamesPlayed, int totalGoals)
        {
            this.dni = dni;
            this.name = name;
            this.gamesPlayed = gamesPlayed;
            this.totalGoals = totalGoals;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }

        public int GamesPlayed { get => gamesPlayed; }
        public float AverageGoal {
            get {
                float averageGoal = (float) totalGoals / gamesPlayed;
                return averageGoal;
            }
        }
        public int TotalGoals { get => totalGoals;}

        public static bool operator == ( Player left, Player right ){
            return left.dni.Equals( right.dni );
        }
        public static bool operator != (Player left, Player right) {
            return !(left == right); //llamo operador sobrecargado "=="
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"jugador.nombre={name}-jugador.dni={dni}-jugador.partidos_jugados={gamesPlayed}-jugador.goles_totales={totalGoals}" +
                $"-jugador.promedio-goles{AverageGoal}");
            return sb.ToString();
        }

    }
}