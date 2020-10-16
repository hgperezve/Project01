using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio45.Entidades
{
    public class Evento : EntidadData<decimal>
    {
        public Evento() { }
        public override decimal Id { get; set; }
        public virtual decimal ComplejoId { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual TimeSpan Duracion { get; set; }
        public virtual decimal NumeroParticipantes { get; set; }
        public virtual decimal NumeroComisarios { get; set; }
        public virtual decimal DeporteId { get; set; }
        public virtual decimal AreaId { get; set; }
    }
}
