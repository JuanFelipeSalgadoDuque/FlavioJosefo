using FlavioJosefo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavioJosefo.Models
{
    public class Player : IPlayer
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        

        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public LinkedList<Player> AddPlayersAtCircle(string[] players)
        {
            LinkedList<Player> winner = new LinkedList<Player>();
            int position = 1;
            foreach (var pla in players)
            {
                Player player = new Player(position, pla.ToString());
                winner.AddLast(player);
                position++;
            }
            return winner;
        }
    }
}