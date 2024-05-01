using System.Security.AccessControl;
using System.Text;

namespace HerncExcC01Lib
{
    public class Player : Person
    { 
        private int gamesPlayed;      
        private int totalGoals;              

        public Player(int dni, string name):base(dni,name) {
            
        }

        public Player(int dni, string name, int gamesPlayed, int totalGoals):base(dni,name) {            
            this.gamesPlayed = gamesPlayed;
            this.totalGoals = totalGoals;
        }

        public int GamesPlayed { get => gamesPlayed; set => gamesPlayed = value; }
        public float AverageGoal {
            get {
                float averageGoal = (float) totalGoals / gamesPlayed;
                return averageGoal;
            }
        }
        public int TotalGoals { get => totalGoals; set => totalGoals = value; }

        public static bool operator == ( Player left, Player right ){
            return left.Dni.Equals( right.Dni );
        }
        public static bool operator != (Player left, Player right) {
            return !(left == right); //llamo operador sobrecargado "=="
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"jugador.nombre={Name}-jugador.dni={Dni}-jugador.partidos_jugados={gamesPlayed}-jugador.goles_totales={totalGoals}" +
                $"-jugador.promedio-goles{AverageGoal}");
            return sb.ToString();
        }

    }
}