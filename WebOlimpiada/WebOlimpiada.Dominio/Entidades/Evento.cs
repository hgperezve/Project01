using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    public class Evento : EntidadData<decimal>
    {
        public Evento() { }

        public virtual decimal ComplejoId { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual Time Duracion { get; set; }
        public virtual decimal NumeroParticipantes { get; set; }
        public virtual decimal NumeroComisarios { get; set; }
        public virtual decimal DeporteId { get; set; }
        public virtual decimal AreaId { get; set; }
    }
}
