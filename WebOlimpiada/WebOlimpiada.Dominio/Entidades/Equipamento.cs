using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    public class Equipamento : EntidadData<decimal>
    {
        public Equipamento() { }
        public virtual string Nombre { get; set; }

    }
}
