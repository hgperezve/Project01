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
    public class EventoComisarioViewController : Controller
    {
        IComisarioService _comisarioService = new ComisarioService();
        // GET: EventoComisarioView
        public ActionResult Index(decimal eventoId, decimal areaId)
        {
            IList<EventoComisario_View> comisariosByEvento = _comisarioService.GetByEventoId(eventoId);
            ViewData["EventoId"] = eventoId;
            ViewData["AreaId"] = areaId;
            return View(comisariosByEvento);
        }

        
    }
}
