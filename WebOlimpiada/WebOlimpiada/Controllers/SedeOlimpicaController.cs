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
    public class SedeOlimpicaController : Controller
    {

        ISedeOlimpicaService _SedeOlimpicaService = new SedeOlimpicaService();

        // GET: SedeOlimpica
        public ActionResult Index()
        {
            IList<SedeOlimpica> list = _SedeOlimpicaService.GetAll();
            return View(list);
        }

        // GET: SedeOlimpica/Details/5
        public ActionResult Details(decimal id)
        {
            return View();
        }

        // GET: SedeOlimpica/Create
        public ActionResult Create()
        {
            SedeOlimpica sedeOlimpica = new SedeOlimpica();
            return View(sedeOlimpica);
        }

        // POST: SedeOlimpica/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                SedeOlimpica sedeOlimpica = new SedeOlimpica();
                sedeOlimpica.SedeOlimpicaId = (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                sedeOlimpica.Nombre = collection["Nombre"].ToString();
                _SedeOlimpicaService.Create(sedeOlimpica);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: SedeOlimpica/Edit/5
        public ActionResult Edit(decimal id)
        {
            SedeOlimpica sedeOlimpica = _SedeOlimpicaService.GetById(id);
            return View(sedeOlimpica);
        }

        // POST: SedeOlimpica/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                SedeOlimpica sedeOlimpica = _SedeOlimpicaService.GetById(id);
                sedeOlimpica.Nombre = collection["Nombre"].ToString();
                _SedeOlimpicaService.Update(sedeOlimpica);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SedeOlimpica/Delete/5
        public ActionResult Delete(decimal id)
        {
            SedeOlimpica sedeOlimpica = _SedeOlimpicaService.GetById(id);
            return View(sedeOlimpica);
        }

        // POST: SedeOlimpica/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _SedeOlimpicaService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
