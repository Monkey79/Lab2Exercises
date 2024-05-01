using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HerncExcC01Lib
{
    public class Team
    {
        private const int TOP = 100;

        private short numPlayers;        
        private List<Player> players;
        private string name;

        public short NumPlayers { get => numPlayers; set => numPlayers = value; }
        public List<Player> Players { get => players; set => players = value; }
        public string Name { get => name; set => name = value; }

        private Team() {
            players = new List<Player>();       
        }
        public Team(short numPlayers, string name):this() {
            this.numPlayers = numPlayers;
            this.name = name;        
        }


        public static bool operator + (Team team,Player player) {            
            bool success = false;

            if (team.ThereIsEmptySpace() && team.ThePlayerIsNotAlreadyCharge(player)) {
                team.players.Add(player);                
                team.numPlayers++;
                success = !success;
            }

            return success;
        }

        private bool ThereIsEmptySpace() {
            return (players.Count < numPlayers);
        }
        private bool ThePlayerIsNotAlreadyCharge(Player nPlayer) {
            Player player = null;
            bool isNotCharge = true;
            int i = 0;
            while(isNotCharge && i < players.Count) {
                player = players[i];
                isNotCharge = (nPlayer != player);
                i++;
            }
            Debug.WriteLine($"esta cargado -->{isNotCharge}");
            return isNotCharge;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"equipo.nombre={name} - equipo.cant-jugadores={numPlayers}");
            sb.AppendLine($"jugadores del equipo {name}");
            foreach( Player player in players ) {
               sb.Append( player.ToString() );
            }
            sb.AppendLine("-------------------------");
            return sb.ToString();
        }
    }
}
