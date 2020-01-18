using FlavioJosefo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlavioJosefo.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [HttpGet]
        public ActionResult AddPlayers(string players ,int step)
        {
            //Split the names in file for \n
            string[] data = players.Split('\n');

            if (data.Length < 2)
            {
                return RedirectToAction("Index", "File"); //File does'n contain enough  players
            }


            Game game = new Game();
            var playersList = game.AddPlayersAtCircle(data);//create players
            var jump = game.Step = step; //set  Step value
            var position = game.GetPosition(playersList.Count(), jump); //find Id to winner player
            var winner = game.PlayGame(playersList, position); //Find the winner player

            ViewBag.winner = winner.Name + " in position " + winner.Id;

            return View();
            
        }
    }
}