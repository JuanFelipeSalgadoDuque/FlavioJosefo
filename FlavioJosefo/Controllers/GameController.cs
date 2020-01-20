namespace FlavioJosefo.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    public class GameController : Controller
    {
        // GET: Game
        [HttpGet]
        public ActionResult AddPlayers(string players, int step)
        {
            //Split the names in file for \n
            string[] data = players.Split('\n');

            if (data.Length < 2 || step < 1)//File does'n contain enough  players
            {
                ViewBag.mensaje = "El archivo debe contener más de un jugador";
                return RedirectToAction("Index", "File");
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