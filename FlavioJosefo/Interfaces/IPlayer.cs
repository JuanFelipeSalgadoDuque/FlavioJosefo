using FlavioJosefo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavioJosefo.Interfaces
{
    interface IPlayer
    {
        LinkedList<Player> AddPlayersAtCircle(string[] players);
    }
}
