using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio.Entidades
{
    public abstract class EntidadData<T>
    {
        public T Id { get; set; }
    }
}
