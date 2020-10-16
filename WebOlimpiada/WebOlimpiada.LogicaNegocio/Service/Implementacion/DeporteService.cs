using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class DeporteService: IDeporteService
    {
        private DeporteRepositorio _deporteRepositorio;

        public DeporteService()
        {
            _deporteRepositorio = new DeporteRepositorio();
        }

        public IList<Deporte> GetAll()
        {
            return _deporteRepositorio.FindAll<Deporte>();
        }

        public Deporte Create(Deporte deporte)
        {
            return _deporteRepositorio.Create<Deporte>(deporte);
        }

        public Deporte GetById(decimal id)
        {
            return _deporteRepositorio.FindById<Deporte>(id);
        }

        public Deporte Update(Deporte deporte)
        {
            return _deporteRepositorio.Update<Deporte>(deporte);
        }

        public void Delete(decimal id)
        {
            _deporteRepositorio.Delete<Deporte>(id);
        }
    }
}
