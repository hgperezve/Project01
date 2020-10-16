using System;
using System.Collections.Generic;
using System.Text;

namespace WebOlimpiada.Dominio45.Entidades
{
    [Serializable]
    public abstract class EntidadData<T> 
    {
        public abstract T Id { get; set; }


        public override int GetHashCode()
        {
            int hash = 57;
            hash = 27 * hash * Id.GetHashCode();
            return hash;
        }

        private bool HasSameBusinessSignatureAs(EntidadData<T> compareTo)
        {
            //Check.Require(compareTo != null, "compareTo may not be null");

            return GetHashCode().Equals(compareTo.GetHashCode());
        }

        private bool HasSameNonDefaultIdAs(EntidadData<T> compareTo)
        {
            //Check.Require(compareTo != null, "compareTo may not be null");

            return (Id != null && !Id.Equals(default(T))) &&
                   (compareTo.Id != null && !compareTo.Id.Equals(default(T))) &&
                   Id.Equals(compareTo.Id);
        }

        public virtual object Clone()
        {
            EntidadData<T> domainObjectClone = (EntidadData<T>)MemberwiseClone();
            domainObjectClone.Id = default(T);

            return domainObjectClone;
        }

    }

}

    
