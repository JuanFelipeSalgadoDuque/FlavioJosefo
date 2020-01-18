using FlavioJosefo.Interfaces;
using FlavioJosefo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlavioJosefo.Controllers
{
    public class Game : IGame
    {
        public LinkedList<Player> PlayersList { get; set; }
        public int Step { get; set; }

        public Game()
        {
   

        }
        // remove N elements in equal steps
        public Player PlayGame(LinkedList<Player> players, int playerId)
        {

            var winnerList = players.Where(x => x.Id == playerId);//find Node to remove
            var winner = winnerList.FirstOrDefault();

            return winner;
        }

        public int GetPosition(int numberOfPlayers, int step){
            if (numberOfPlayers == 1)
                return 1;
            else
                /* The position returned  
                by josephus(n - 1, k) is 
                adjusted because the 
                recursive call josephus(n 
                - 1, k) considers the  
                original position k%n + 1 
                as position 1 */
                return (GetPosition(numberOfPlayers - 1, step)
                           + step - 1) % numberOfPlayers + 1;
        }

        public LinkedList<Player> AddPlayersAtCircle(string[] players)
        {
            LinkedList<Player> playersList = new LinkedList<Player>();
            int position = 1;
            foreach (var pla in players)
            {
                Player player = new Player(position, pla.ToString());
                playersList.AddLast(player);
                position++;
            }
            return playersList;
        }
    }
}