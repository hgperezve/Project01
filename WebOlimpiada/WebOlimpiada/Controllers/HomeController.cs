using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.LogicaNegocio.Service;
using WebOlimpiada.LogicaNegocio.Service.Implementacion;

namespace WebOlimpiada.Controllers
{
    public class HomeController : Controller
    {
        IUsuarioService _usuarioService = new UsuarioService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login (Usuario objUsuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = _usuarioService.GetByCodigo(objUsuario.Codigo, objUsuario.Password);
                if (usuario != null)
                {
                    Session["CODIGO"] = usuario.Codigo;
                    Session["NOMBRE"] = usuario.Nombre;
                    return RedirectToAction("Index","SedeOlimpica");
                }
            }
            return View(objUsuario);
        }

    }
}