using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio45.Entidades
{
    [Serializable]    
    public class SedeOlimpica : EntidadData<decimal>
    {
        //protected string _nombre;

        public SedeOlimpica() { }
        public override decimal Id { get; set; }
        public virtual string Nombre { get; set; }
    }
}
