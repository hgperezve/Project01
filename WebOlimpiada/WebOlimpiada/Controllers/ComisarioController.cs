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
    public class ComisarioController : Controller
    {
        IComisarioService _comisarioService = new ComisarioService();
        // GET: Comisario
        public ActionResult Index()
        {
            IList<Comisario> comisarios = _comisarioService.GetAll();
            return View(comisarios);
        }

        // GET: Comisario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comisario/Create
        public ActionResult Create()
        {
            Comisario comisario = new Comisario();
            return View(comisario);
        }

        // POST: Comisario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Comisario comisario = new Comisario();
                comisario.ComisarioId = (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                comisario.Nombre = collection["Nombre"].ToString();
                comisario.Tarea = collection["Tarea"].ToString();
                _comisarioService.Create(comisario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comisario/Edit/5
        public ActionResult Edit(decimal id)
        {
            Comisario comisario = _comisarioService.GetById(id);
            return View(comisario);
        }

        // POST: Comisario/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Comisario comisario = _comisarioService.GetById(id);
                comisario.Nombre = collection["Nombre"].ToString();
                comisario.Tarea = collection["Tarea"].ToString();
                _comisarioService.Update(comisario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comisario/Delete/5
        public ActionResult Delete(decimal id)
        {
            Comisario comisario = _comisarioService.GetById(id);
            return View(comisario);
        }

        // POST: Comisario/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _comisarioService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
