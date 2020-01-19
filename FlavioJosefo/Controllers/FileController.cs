using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            try
            {
                //Read all file
                string result = new StreamReader(file.InputStream).ReadToEnd();

                
                //Mi otro controlador necesita 2 parámetros
                return RedirectToAction("AddPlayers", "Game", new {players = result, step = jump});

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