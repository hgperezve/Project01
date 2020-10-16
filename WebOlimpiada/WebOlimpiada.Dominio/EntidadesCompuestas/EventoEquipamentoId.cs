using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.EntidadesCompuestas
{
    public class EventoEquipamentoId
    {
        protected decimal _eventoid;
        protected decimal _equipamentoid;

        public EventoEquipamentoId() { }

        public EventoEquipamentoId(decimal pEventoId, decimal pEquipamentoId)
        {
            this._eventoid = pEventoId;
            this._equipamentoid = pEquipamentoId;
        }

        public virtual decimal EventoId
        {
            get { return _eventoid; }
            set { _eventoid = value; }

        }

        public virtual decimal EquipamentoId
        {
            get { return _equipamentoid; }
            set { _equipamentoid = value; }

        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            EventoEquipamentoId castObj = null;
            try
            {
                castObj = (EventoEquipamentoId)obj;
            }
            catch (Exception) { return false; }
            return (castObj != null) &&
                (this._eventoid == castObj.EventoId) &&
                (this._equipamentoid == castObj.EquipamentoId);
        }

        public override int GetHashCode()
        {
            int hash = 57;
            hash = 27 * hash * _eventoid.GetHashCode();
            hash = 27 * hash * _equipamentoid.GetHashCode();
            return hash;
        }
    }
}
