using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    public class Complejo : EntidadData<decimal>
    {
        public Complejo() { }

        public virtual decimal SedeOlimpicaId { get; set; }
        public virtual string Localizacion { get; set; }
        public virtual string JefeDeOrganizacion { get; set; }
        public virtual decimal AreaTotal { get; set; }
        public virtual decimal PresupuestoAproximando { get; set; }
        public virtual string Tipo { get; set; }
    }
}
