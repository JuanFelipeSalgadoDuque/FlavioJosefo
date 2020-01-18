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

        // remove N elements in equal steps
        public LinkedList<Player> PlayGame(LinkedList<Player> players, int jump, int start = 1)
        {
            var numberPlayers = players.Count();
            if (numberPlayers <= 1 || jump < 1 || start < 1) return null;

            LinkedList<Player> deads = new LinkedList<Player>();
            int i = (start - 2) % numberPlayers; 
            for (int j = numberPlayers - 1; j > 0; j--)
            {
                i = (i + jump) % numberPlayers--; //find the index of player that will die
                var nodesToRemove = players.Where(x => x.Id == i); //find Node to remove
                foreach (var item in nodesToRemove)
                {
                    deads.AddLast(item); //add the deleted player to another list
                    players.Remove(item); //delete player of players list

                }
                i--; //decrease the index to continue playing
            }

            return players;
        }
    }
}