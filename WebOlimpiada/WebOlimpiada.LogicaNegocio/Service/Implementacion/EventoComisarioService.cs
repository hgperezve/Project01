using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EventoComisarioService : IEventoComisarioService
    {
        private EventoComisarioRepositorio _eventoComisarioRepositorio;

        public EventoComisarioService()
        {
            _eventoComisarioRepositorio = new EventoComisarioRepositorio();
        }

        public Evento_Comisario Create(Evento_Comisario eventoComisario)
        {
            return _eventoComisarioRepositorio.Create<Evento_Comisario>(eventoComisario);
        }

        public Evento_Comisario GetByIds(decimal eventoId, decimal comisario)
        {
            return _eventoComisarioRepositorio.FindByIds(eventoId, comisario);
        }

        public Evento_Comisario Update(Evento_Comisario eventoComisario)
        {
            return _eventoComisarioRepositorio.Update<Evento_Comisario>(eventoComisario);
        }

        public void Delete(Evento_Comisario eventoComisario)
        {
            _eventoComisarioRepositorio.Delete<Evento_Comisario>(eventoComisario.EventoId, eventoComisario.ComisarioId);
        }
    }
}
