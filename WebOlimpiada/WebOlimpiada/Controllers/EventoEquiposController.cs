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
    public class EventoEquiposController : Controller
    {
        IEventoEquipamentoService _eventoEquipamentoService = new EventoEquipamentoService();
        IEquipamentoService _equiposService = new EquipamentoService();
        IEventoService _eventoService = new EventoService();
        private static decimal pEventoId;

        public void SetEnttyDataToForm(decimal eventoId)
        {
            //IList<Equipamento> equipos = _equiposService.GetAll<Equipamento>();
            IList<Equipamento> equipos = _equiposService.GetExcludeEventoId(eventoId);
            ViewData["EquiposLista"] = new SelectList(equipos, "EquipamentoId", "Nombre");
        }

        // GET: EventoEquipos/Create
        public ActionResult Create(decimal eventoId)
        {
            Evento_Equipamento eventoEquipamento = new Evento_Equipamento();
            eventoEquipamento.EventoId = eventoId;
            pEventoId = eventoId;
            SetEnttyDataToForm(eventoId);
            ViewData["EventoId"] = eventoId;
            return View(eventoEquipamento);
        }

        // POST: EventoEquipos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Evento_Equipamento eventoEquipamento = new Evento_Equipamento();
                eventoEquipamento.EventoId = pEventoId;
                eventoEquipamento.EquipamentoId = Decimal.Parse(collection["EquipamentoId"].ToString());
                eventoEquipamento.Cantidad = Decimal.Parse(collection["Cantidad"].ToString());
                _eventoEquipamentoService.Create(eventoEquipamento);
                Evento evento = _eventoService.GetById(pEventoId);
                return RedirectToAction("Index","Evento", new { areaId = evento.AreaId });
            }
            catch(Exception ex)
            {
                SetEnttyDataToForm(pEventoId);
                return View();
            }
        }

        // GET: EventoEquipos/Edit/5
        public ActionResult Edit(decimal eventoId, decimal equipamentoId)
        {
            Evento_Equipamento eventoEquipamento = _eventoEquipamentoService.GetByIds(eventoId, equipamentoId);
            IList<Equipamento> equipos = _equiposService.GetAll<Equipamento>();
            ViewData["EquiposLista"] = new SelectList(equipos, "EquipamentoId", "Nombre");
            ViewData["EventoId"] = eventoId;
            return View(eventoEquipamento);
        }

        // POST: EventoEquipos/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
               

                decimal eventoId = Decimal.Parse(collection["EventoId"].ToString());
                decimal equipamentoId = Decimal.Parse(collection["EquipamentoId"].ToString());
                Evento_Equipamento eventoEquipamento = _eventoEquipamentoService.GetByIds(eventoId, equipamentoId);
                eventoEquipamento.Cantidad = Decimal.Parse(collection["Cantidad"].ToString());
                _eventoEquipamentoService.Update(eventoEquipamento);
                Evento evento = _eventoService.GetById(eventoId);
                return RedirectToAction("Index", "Evento", new { areaId = evento.AreaId });
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: EventoEquipos/Delete/5
        public ActionResult Delete(decimal eventoId, decimal equipamentoId)
        {
            Evento_Equipamento eventoEquipamento = _eventoEquipamentoService.GetByIds(eventoId, equipamentoId);
            IList<Equipamento> equipos = _equiposService.GetAll<Equipamento>();
            ViewData["EquiposLista"] = new SelectList(equipos, "EquipamentoId", "Nombre");
            ViewData["EventoId"] = eventoId;
            return View(eventoEquipamento);
        }

        // POST: EventoEquipos/Delete/5
        [HttpPost]
        public ActionResult Delete( FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                decimal eventoId = Decimal.Parse(collection["EventoId"].ToString());
                decimal equipamentoId = Decimal.Parse(collection["EquipamentoId"].ToString());
                Evento_Equipamento eventoEquipamento = _eventoEquipamentoService.GetByIds(eventoId, equipamentoId);
                _eventoEquipamentoService.Delete(eventoEquipamento);
                Evento evento = _eventoService.GetById(eventoId);
                return RedirectToAction("Index", "Evento", new { areaId = evento.AreaId });
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
