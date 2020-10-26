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
    public class EquipamentoController : Controller
    {
        IEquipamentoService _equipamentoService = new EquipamentoService();
        // GET: Equipamento
        public ActionResult Index()
        {
            IList<Equipamento> equipamentoList = _equipamentoService.GetAll<Equipamento>();
            return View(equipamentoList);
        }

        // GET: Equipamento/Details/5
        public ActionResult Details(decimal id)
        {
            return View();
        }

        // GET: Equipamento/Create
        public ActionResult Create()
        {
            Equipamento equipamento = new Equipamento();

            return View(equipamento);
        }

        // POST: Equipamento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Equipamento equipamento = new Equipamento();
                equipamento.EquipamentoId= (decimal)(UniqueKeyGenerator.GetInstance().GetUniqueKey());
                equipamento.Nombre = collection["Nombre"].ToString();
                _equipamentoService.Create(equipamento);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipamento/Edit/5
        public ActionResult Edit(decimal id)
        {
            Equipamento equipamento = _equipamentoService.GetById<Equipamento>(id);
            return View(equipamento);
        }

        // POST: Equipamento/Edit/5
        [HttpPost]
        public ActionResult Edit(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Equipamento equipamento = _equipamentoService.GetById<Equipamento>(id);
                equipamento.Nombre = collection["Nombre"].ToString();
                _equipamentoService.Update(equipamento);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipamento/Delete/5
        public ActionResult Delete(decimal id)
        {
            Equipamento equipamento = _equipamentoService.GetById<Equipamento>(id);
            return View(equipamento);
        }

        // POST: Equipamento/Delete/5
        [HttpPost]
        public ActionResult Delete(decimal id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _equipamentoService.Delete<Equipamento>(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
