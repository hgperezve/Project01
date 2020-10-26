using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EventoComisarioService : GenericoService<Evento_Comisario, decimal>, IEventoComisarioService
    {
        //private EventoComisarioRepositorio _eventoComisarioRepositorio;

         public IEventoComisarioRepositorio EventoComisarioRepositorio
        {
            get { return (IEventoComisarioRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }

        public EventoComisarioService()
        {
            EventoComisarioRepositorio = new EventoComisarioRepositorio();
        }

        //public Evento_Comisario Create(Evento_Comisario eventoComisario)
        //{
        //    return _eventoComisarioRepositorio.Create<Evento_Comisario>(eventoComisario);
        //}

        public Evento_Comisario GetByIds(decimal eventoId, decimal comisario)
        {
            return EventoComisarioRepositorio.FindByIds(eventoId, comisario);
        }

        //public Evento_Comisario Update(Evento_Comisario eventoComisario)
        //{
        //    return _eventoComisarioRepositorio.Update<Evento_Comisario>(eventoComisario);
        //}

        //public void Delete(Evento_Comisario eventoComisario)
        //{
        //    _eventoComisarioRepositorio.Delete<Evento_Comisario>(eventoComisario.EventoId, eventoComisario.ComisarioId);
        //}
    }
}
