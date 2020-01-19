using FlavioJosefo.Interfaces;
using FlavioJosefo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavioJosefo.Controllers
{
    public class Game : IGame
    {
        [Required]
        public LinkedList<Player> PlayersList { get; set; }
        
        [Required]
        public int Step { get; set; }

        public Game()
        {
   

        }
        // remove element by Id
        public Player PlayGame(LinkedList<Player> players, int playerId)
        {
            if (players.Count() == 0 || playerId < 1)
            {
                return null;
            }
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


        //Create players and add to LinkedList
        public LinkedList<Player> AddPlayersAtCircle(string[] players)
        {
            if (players.Length == 0)
            {
                return null;
            }
           
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