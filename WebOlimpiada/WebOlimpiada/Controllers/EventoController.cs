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
    public class EventoController : Controller
    {
        IEventoService _eventoService = new EventoService();
        IAreaService _areaService = new AreaService();
        IDeporteService _deporteService = new DeporteService();
        private static decimal pAreaId;
        // GET: Evento
        public ActionResult Index(decimal areaId)
        {
            pAreaId = areaId;
            Area area = _areaService.GetById(areaId);
            
            ViewData["AreaNombre"] = area.Nombre;
            IList<Evento> eventos = _eventoService.GetByAreaId(areaId);
            return View(eventos);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            Evento evento = new Evento();
            evento.AreaId = pAreaId;
            IList<Deporte> deportes = _deporteService.GetAll();
            ViewData["DeporteLista"] = new SelectList(deportes, "DeporteId", "Nombre");
            return View(evento);
        }

        // POST: Evento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Evento evento = new Evento();
                evento.AreaId = pAreaId;
                evento.EventoId = (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                try { evento.Fecha = DateTime.Parse(collection["Fecha"].ToString()); }
                catch (Exception ex) { }

                try { evento.Duracion = TimeSpan.Parse(collection["Duracion"].ToString()); ; }
                catch (Exception ex) { }
                evento.NumeroParticipantes = Decimal.Parse(collection["NumeroParticipantes"]);
                evento.NumeroComisarios = Decimal.Parse(collection["NumeroComisarios"]);
                evento.DeporteId = Decimal.Parse(collection["DeporteId"]);
                _eventoService.Create(evento);
                return RedirectToAction("Index", new { areaId = pAreaId });
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(decimal id)
        {
            Evento evento = _eventoService.GetById(id);
            IList<Deporte> deportes = _deporteService.GetAll();
            ViewData["DeporteLista"] = new SelectList(deportes, "DeporteId", "Nombre");
            return View(evento);
        }

        // POST: Evento/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Evento evento = _eventoService.GetById(id);
                try { evento.Fecha = DateTime.Parse(collection["Fecha"].ToString()); }
                catch (Exception ex) { }

                try { evento.Duracion = TimeSpan.Parse(collection["Duracion"].ToString()); ; }
                catch (Exception ex) { }
                evento.NumeroParticipantes = Decimal.Parse(collection["NumeroParticipantes"]);
                evento.NumeroComisarios = Decimal.Parse(collection["NumeroComisarios"]);
                evento.DeporteId = Decimal.Parse(collection["DeporteId"]);
                _eventoService.Update(evento);
                return RedirectToAction("Index", new { areaId = pAreaId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evento/Delete/5
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
