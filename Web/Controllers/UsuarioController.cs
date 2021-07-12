using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(listaUsuario);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            listaUsuario.Add(model);
            return RedirectToAction("List");
        }
    }
}