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
    public class DeporteController : Controller
    {
        IDeporteService _deporteService = new DeporteService();
        
        // GET: Deporte
        public ActionResult Index()
        {
            IList<Deporte> deportes = _deporteService.GetAll<Deporte>();
            return View(deportes);
        }

        // GET: Deporte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deporte/Create
        public ActionResult Create()
        {
            Deporte deporte = new Deporte();
            return View(deporte);
        }

        // POST: Deporte/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Deporte deporte = new Deporte();
                deporte.DeporteId = (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                deporte.Nombre = collection["Nombre"].ToString();
                _deporteService.Create(deporte);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Deporte/Edit/5
        public ActionResult Edit(Decimal  id)
        {
            Deporte deporte = _deporteService.GetById<Deporte>(id);
            return View(deporte);
        }

        // POST: Deporte/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Deporte deporte = _deporteService.GetById<Deporte>(id);
                deporte.Nombre = collection["Nombre"].ToString();
                _deporteService.Update(deporte);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deporte/Delete/5
        public ActionResult Delete(decimal id)
        {
            Deporte deporte = _deporteService.GetById<Deporte>(id);
            return View(deporte);
        }

        // POST: Deporte/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                //Deporte deporte = _deporteService.GetById(id);
                _deporteService.Delete<Deporte>(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
