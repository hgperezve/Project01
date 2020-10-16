using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public abstract class GenericoService<T, IdT>
    {
        private GenericoRepositorio<T,IdT> _genericoRepositorio;

        //public GenericoService<T, IdT>(T objecto)
        //{
        //    _genericoRepositorio = new GenericoRepositorio<T, IdT>();
        //}

    //public IList<T> GetAll<T>()
    //{
    //    return _genericoRepositorio.FindAll<T>();
    //}
}
}
