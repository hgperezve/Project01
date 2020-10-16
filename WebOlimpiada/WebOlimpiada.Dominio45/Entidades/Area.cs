using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio45.Entidades
{
    public class Area: EntidadData<decimal>
    {
        public Area() { }

        public override decimal Id { get; set; }
        public virtual decimal ComplejoId { get; set; }
        public virtual decimal AreaOcupada { get; set; }
        public virtual string IndicadorLocalizacion { get; set; }
        public virtual string Nombre { get; set; }
    }
}
