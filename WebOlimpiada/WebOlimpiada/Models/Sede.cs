using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOlimpiada.Models
{
    public class Sede
    {
        public Sede() { }

        public decimal SelectOlimpicaId
        { get; set; }

        public string Nombre { get; set; }
    }
}