using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.LogicaNegocio.Service;
using WebOlimpiada.LogicaNegocio.Service.Implementacion;
using WebOlimpiada.Utility;

namespace WebOlimpiada.Controllers
{
    public class ComplejoController : Controller
    {
        IComplejoService _ComplejoService = new ComplejoService();
        private static decimal pSedeOlimpicaId;
        // GET: Complejo
        public ActionResult Index(decimal sedeOlimpicaId)
        {
            pSedeOlimpicaId = sedeOlimpicaId;
            IList<Complejo> complejos = _ComplejoService.GetBySedeOlimpicaId(sedeOlimpicaId);
            ViewData["pSedeOlimpicaId"] = pSedeOlimpicaId;
            return View(complejos);
        }


        // GET: Complejo/Create
        public ActionResult Create()
        {
            Complejo complejo = new Complejo();
            complejo.SedeOlimpicaId = pSedeOlimpicaId;
            ViewData["pSedeOlimpicaId"] = pSedeOlimpicaId;
            return View(complejo);
        }

        // POST: Complejo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Complejo complejo = new Complejo();
                complejo.SedeOlimpicaId = pSedeOlimpicaId;
                complejo.ComplejoId = (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                complejo.Localizacion = collection["Localizacion"].ToString();
                complejo.Nombre = collection["Nombre"].ToString();
                complejo.JefeDeOrganizacion = collection["JefeDeOrganizacion"].ToString();
                complejo.AreaTotal = Convert.ToDecimal(collection["AreaTotal"]);
                complejo.PresupuestoAproximando = Convert.ToDecimal(collection["PresupuestoAproximando"].ToString());
                complejo.Tipo = collection["Tipo"].ToString();
                _ComplejoService.Create(complejo);
                return RedirectToAction("Index",new { sedeOlimpicaId = pSedeOlimpicaId });
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Complejo/Edit/5
        public ActionResult Edit(decimal id)
        {
            Complejo complejo = _ComplejoService.GetById<Complejo>(id);
            ViewData["pSedeOlimpicaId"] = pSedeOlimpicaId;
            return View(complejo);
        }

        // POST: Complejo/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Complejo complejo = _ComplejoService.GetById<Complejo>(id);
                complejo.SedeOlimpicaId = pSedeOlimpicaId;
                complejo.Localizacion = collection["Localizacion"].ToString();
                complejo.Nombre = collection["Nombre"].ToString();
                complejo.JefeDeOrganizacion = collection["JefeDeOrganizacion"].ToString();
                complejo.AreaTotal = Convert.ToDecimal(collection["AreaTotal"]);
                complejo.PresupuestoAproximando = Convert.ToDecimal(collection["PresupuestoAproximando"].ToString());
                complejo.Tipo = collection["Tipo"].ToString();
                _ComplejoService.Update(complejo);
                return RedirectToAction("Index", new { sedeOlimpicaId = pSedeOlimpicaId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Complejo/Delete/5
        public ActionResult Delete(decimal id)
        {
            Complejo complejo = _ComplejoService.GetById<Complejo>(id);
            ViewData["pSedeOlimpicaId"] = pSedeOlimpicaId;
            return View(complejo);
        }

        // POST: Complejo/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _ComplejoService.Delete<Complejo>(id);
                return RedirectToAction("Index", new { sedeOlimpicaId = pSedeOlimpicaId });
            }
            catch
            {
                return View();
            }
        }
    }
}
