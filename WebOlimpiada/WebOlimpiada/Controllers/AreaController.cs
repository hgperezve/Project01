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
    public class AreaController : Controller
    {

        IAreaService _AreaService = new AreaService();
        IComplejoService _ComplejoService = new ComplejoService();
        private static decimal pComplejoId;


        // GET: Area
        public ActionResult Index(decimal complejoId)
        {
            pComplejoId = complejoId;
            bool estaHabilitadoCrear = true;
            IList<Area> areas = _AreaService.GetByComplejoId(complejoId);
            Complejo complejo = _ComplejoService.GetById(complejoId);
            if (complejo != null) {
                if (complejo.Tipo.Equals("Unico") && areas.Count==1) {
                    estaHabilitadoCrear = false;
                }

            }
            
            ViewData["pComplejoId"] = pComplejoId;
            ViewData["EstaHabilitadoCrear"] = estaHabilitadoCrear;
            ViewData["Localizacion"] = complejo.Localizacion;
            return View(areas);
        }

        // GET: Area/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Area/Create
        public ActionResult Create()
        {
            Area area = new Area();
            area.ComplejoId = pComplejoId;
            return View(area);
        }

        // POST: Area/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Area area = new Area();
                area.AreaId= (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                area.AreaOcupada = Convert.ToDecimal(collection["AreaOcupada"]);
                area.IndicadorLocalizacion = (collection["IndicadorLocalizacion"]).ToString();
                area.Nombre = (collection["Nombre"]).ToString();
                area.ComplejoId = pComplejoId;
                _AreaService.Create(area);

                return RedirectToAction("Index", new { complejoId = pComplejoId });
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Area/Edit/5
        public ActionResult Edit(decimal id)
        {
            Area area = _AreaService.GetById(id);
            return View(area);
        }

        // POST: Area/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Area area = _AreaService.GetById(id);
                area.AreaOcupada = Convert.ToDecimal(collection["AreaOcupada"]);
                area.IndicadorLocalizacion = (collection["IndicadorLocalizacion"]).ToString();
                area.Nombre = (collection["Nombre"]).ToString();
                area.ComplejoId = pComplejoId;
                _AreaService.Update(area);
                return RedirectToAction("Index", new { complejoId = pComplejoId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Area/Delete/5
        public ActionResult Delete(decimal id)
        {
            Area area = _AreaService.GetById(id);
            return View(area);
        }

        // POST: Area/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _AreaService.Delete(id);
                return RedirectToAction("Index", new { complejoId = pComplejoId });
            }
            catch
            {
                return View();
            }
        }
    }
}
