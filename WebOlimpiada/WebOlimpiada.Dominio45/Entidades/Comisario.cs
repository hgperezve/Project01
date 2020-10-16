using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.Dominio45.Entidades
{
    public class Comisario : EntidadData<decimal>
    {
        public Comisario() { }

        public override decimal Id { get; set; }

        public virtual string Nombre { get; set; }

        public virtual string Tarea { get; set; }
    }
}
