using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOlimpiada.LogicaNegocio.Service;
using WebOlimpiada.LogicaNegocio.Service.Implementacion;
using WebOlimpiada.Models;

namespace WebOlimpiada.Controllers
{
    public class SedeController : Controller
    {

        // GET: Sede
        public ActionResult Index()
        {
            IList<Sede> sedes = new List<Sede>();
            sedes.Add(new Sede() { SelectOlimpicaId =100000, Nombre="Sede 00000"});
            sedes.Add(new Sede() { SelectOlimpicaId =100001, Nombre="Sede 00001"});
            sedes.Add(new Sede() { SelectOlimpicaId =100002, Nombre="Sede 00002"});
            sedes.Add(new Sede() { SelectOlimpicaId =100003, Nombre="Sede 00003"});

            return View(sedes);
        }

        // GET: Sede/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sede/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sede/Create
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

        // GET: Sede/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sede/Edit/5
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

        // GET: Sede/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sede/Delete/5
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
