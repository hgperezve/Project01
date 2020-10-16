using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EventoService : IEventoService
    {
        private EventoRepositorio _eventoRepositorio;

        public EventoService()
        {
            _eventoRepositorio = new EventoRepositorio();
        }

        public IList<Evento> GetAll()
        {
            return _eventoRepositorio.FindAll<Evento>();
        }

        public Evento Create(Evento evento)
        {
            return _eventoRepositorio.Create<Evento>(evento);
        }

        public Evento GetById(decimal id)
        {
            return _eventoRepositorio.FindById<Evento>(id);
        }

        public Evento Update(Evento evento)
        {
            return _eventoRepositorio.Update<Evento>(evento);
        }

        public void Delete(decimal id)
        {
            _eventoRepositorio.Delete<Evento>(id);
        }

        public IList<Evento> GetByAreaId(decimal pAreaId)
        {
            return _eventoRepositorio.FindByAreaId(pAreaId);
        }
    }
}
