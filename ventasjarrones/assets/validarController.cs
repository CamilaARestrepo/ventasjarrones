using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ventasjarrones.assets;
using ventasjarrones.Properties;

namespace ventasjarrones.assets
{
    public class validarController : Controller
    {
        // GET: validar
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index( String tbusuario, String tbclave)
        {
            loguin
            return View();
        }
    }
}