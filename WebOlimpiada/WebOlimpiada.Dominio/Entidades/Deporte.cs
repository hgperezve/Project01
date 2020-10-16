using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    public class Deporte : EntidadData<decimal>
    {
        public Deporte() { }

        public virtual string Nombre { get; set; }
    }
}
