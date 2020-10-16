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
    public class EventoEquipamentoController : Controller
    {
        IEquipamentoService _equipamentoService = new EquipamentoService();
        
        // GET: EventoEquipamento
        public ActionResult Index(decimal eventoId)
        {
            ViewData["EventoId"] = eventoId;
            IList<EventoEquipamento_View> equiposPorEvento = _equipamentoService.GetByEventoIdView(eventoId);
            return View(equiposPorEvento);
        }

        // GET: EventoEquipamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventoEquipamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoEquipamento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoEquipamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventoEquipamento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoEquipamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventoEquipamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
