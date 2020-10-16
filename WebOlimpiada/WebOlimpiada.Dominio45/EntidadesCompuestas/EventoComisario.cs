using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.Dominio45.Entidades;

namespace WebOlimpiada.Dominio45.EntidadesCompuestas
{
    [Serializable]
    public class EventoComisario : EntidadData<EventoComisarioId>
    {
        protected EventoComisarioId _id;

        public EventoComisario() { }

        public EventoComisario(EventoComisarioId pId)
        {
            this._id = pId;
        }

        public override EventoComisarioId Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
