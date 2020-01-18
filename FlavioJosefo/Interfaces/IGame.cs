using FlavioJosefo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavioJosefo.Interfaces
{
    interface IGame
    {
		
		LinkedList<Player> PlayGame(LinkedList<Player> players, int jump, int start = 1);
		LinkedList<Player> AddPlayersAtCircle(string[] players);

	}
}
