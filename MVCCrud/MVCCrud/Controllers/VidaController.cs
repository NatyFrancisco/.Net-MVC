using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models.ViewModels;
//Obtiene los elementos a partir de Entityframework
using MVCCrud.Models;

namespace MVCCrud.Controllers
{
    public class VidaController : Controller 
    {
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}
