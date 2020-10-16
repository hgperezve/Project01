using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio45.Entidades
{
    public class Equipamento : EntidadData<decimal>
    {
        public Equipamento() { }
        public override decimal Id { get; set; }
        public virtual string Nombre { get; set; }

    }
}
