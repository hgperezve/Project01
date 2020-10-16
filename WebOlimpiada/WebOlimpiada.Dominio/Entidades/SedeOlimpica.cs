using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    [Serializable]    
    public class SedeOlimpica : EntidadData<decimal>
    {
        //protected string _nombre;

        public SedeOlimpica() { }

        public virtual string Nombre { get; set; }
    }
}
