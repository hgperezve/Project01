using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.EntidadesCompuestas
{
    public class EventoEquipamento : EntidadData<EventoEquipamentoId>
    {
        protected EventoEquipamentoId _id;

        public EventoEquipamento() { }

        public EventoEquipamento(EventoEquipamentoId pId)
        {
            this._id = pId;
        }

        public override EventoEquipamentoId Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual decimal Cantidad { get; set; }
    }
}
