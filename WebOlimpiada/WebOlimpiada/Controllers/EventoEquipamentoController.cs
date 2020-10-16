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
        public ActionResult Index(decimal eventoId, decimal areaId)
        {
            ViewData["EventoId"] = eventoId;
            ViewData["AreaId"] = areaId;
            IList<EventoEquipamento_View> equiposPorEvento = _equipamentoService.GetByEventoIdView(eventoId);
            return View(equiposPorEvento);
        }
    }
}
