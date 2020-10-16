using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.Dominio45.EntidadesCompuestas
{
    [Serializable]
    public class EventoComisarioId
    {
        protected decimal _eventoid;
        protected decimal _comisarioid;

        public EventoComisarioId() { }

        public EventoComisarioId(decimal pEventoId, decimal pComisarioId)
        {
            this._eventoid = pEventoId;
            this._comisarioid = pComisarioId;
        }

        public virtual decimal EventoId
        {
            get { return _eventoid; }
            set { _eventoid = value; }

        }

        public virtual decimal ComisarioId
        {
            get { return _comisarioid; }
            set { _comisarioid = value; }

        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            EventoComisarioId castObj = null;
            try
            {
                castObj = (EventoComisarioId)obj;
            }
            catch (Exception) { return false; }
            return (castObj != null) &&
                (this._eventoid == castObj.EventoId) &&
                (this._comisarioid == castObj.ComisarioId);
        }

        public override int GetHashCode()
        {
            int hash = 57;
            hash = 27 * hash * _eventoid.GetHashCode();
            hash = 27 * hash * _comisarioid.GetHashCode();
            return hash;
        }
    }
}
