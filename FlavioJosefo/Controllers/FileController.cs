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

                //Split the names in file for \n
                string[] data = result.Split('\n');

                //Mi otro controlador necesita 2 parámetros
                return RedirectToAction("Datos", new { nom = data[0].ToString(), mail = data[1].ToString() });

            }
            catch (Exception ex)
            {
                ViewBag.mensaje = "Se produjo un error : " + ex.Message;
            }

            return View("Index");
        }
    }
}