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
    public class EventoComisarioController : Controller
    {
        IEventoComisarioService _eventoComisarioService = new EventoComisarioService();
        IComisarioService _comisarioService = new ComisarioService();
        private static decimal pEventoId;
        // GET: EventoComisario/Create
        public ActionResult Create(decimal eventoId)
        {
            pEventoId = eventoId;
            Evento_Comisario eventoComisario = new Evento_Comisario();
            eventoComisario.EventoId = eventoId;
            IList<Comisario> comisarios = _comisarioService.GetAll();
            ViewData["ComisarioLista"] = new SelectList(comisarios, "ComisarioId", "Nombre");
            return View(eventoComisario);
        }

        // POST: EventoComisario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Evento_Comisario eventoComisario = new Evento_Comisario();
                eventoComisario.EventoId = pEventoId;
                eventoComisario.ComisarioId = Decimal.Parse(collection["ComisarioId"].ToString());
                _eventoComisarioService.Create(eventoComisario);
                return RedirectToAction("Index", "EventoComisarioView", new { eventoId = pEventoId });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoComisario/Delete/5
        public ActionResult Delete(decimal eventoId, decimal comisarioId)
        {
            Evento_Comisario eventoComisario = _eventoComisarioService.GetByIds(eventoId, comisarioId);
            Comisario comisario = _comisarioService.GetById(comisarioId);
            ViewData["EventoId"] = eventoId;
            ViewData["ComisarioId"] = comisarioId;
            ViewData["ComisarioNombre"] = comisario.Nombre;
            return View(eventoComisario);
        }

        // POST: EventoComisario/Delete/5
        [HttpPost]
        public ActionResult Delete( FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                decimal eventoId = Decimal.Parse(collection["EventoId"].ToString());
                decimal comisarioId = Decimal.Parse(collection["ComisarioId"].ToString());
                Evento_Comisario eventoComisario = _eventoComisarioService.GetByIds(eventoId, comisarioId);
                _eventoComisarioService.Delete(eventoComisario);
                return RedirectToAction("Index", "EventoComisarioView", new { eventoId = pEventoId });
            }
            catch
            {
                return View();
            }
        }
    }
}
