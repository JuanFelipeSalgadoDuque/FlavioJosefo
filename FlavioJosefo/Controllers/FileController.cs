using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace FlavioJosefo.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, int jump)
        {
            string name = file.FileName;
            string[] extension = name.Split('.');
            if (!extension[1].Equals("txt"))
            {
                ViewBag.mensaje = "Se produjo un error : Solo se permite tipo de archivo con extension .txt";
                return View("Index");
            }

            try
            {
                //Read all file
                string result = new StreamReader(file.InputStream).ReadToEnd();


                //Mi otro controlador necesita 2 parámetros
                return RedirectToAction("AddPlayers", "Game", new { players = result, step = jump });

            }
            catch (FileNotFoundException ex)
            {
                ViewBag.mensaje = "Se produjo un error : " + ex.Message;
                return View("Index");
            }
            catch (Exception ex)
            {
                ViewBag.mensaje = "Se produjo un error : " + ex.Message;
                return View("Index");
            }

        }
    }
}