using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinal.Controllers
{
    public class JoKenPoController : Controller
    {
        // GET: JoKenPo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Game(int jogada)
        {

            return View("Index");
        }

    }
}