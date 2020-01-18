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
		
		Player PlayGame(LinkedList<Player> players, int playerId);
		LinkedList<Player> AddPlayersAtCircle(string[] players);

	}
}
