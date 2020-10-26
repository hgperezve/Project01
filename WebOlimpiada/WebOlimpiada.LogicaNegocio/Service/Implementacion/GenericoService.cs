using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Interfaz;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public abstract class GenericoService<T, IdT>: IGenericoService<T, IdT>
    {
        protected IGenericoRepositorio<T,IdT> _genericoRepo;

        public IGenericoRepositorio<T, IdT> _genericoRepositorio
        {
            get { return _genericoRepo; }
        }

        public IList<T> GetAll<T>() where T : class
        {
            return _genericoRepositorio.FindAll<T>();
        }

        public T Create<T>(T entity) where T : class
        {
            return _genericoRepositorio.Create<T>(entity);
        }

        public T GetById<T>(IdT id) where T : class
        {
            return _genericoRepositorio.FindById<T>(id);
        }

        public T Update<T>(T entity) where T : class
        {
            return _genericoRepositorio.Update<T>(entity);
        }

        public void Delete<T>(IdT id) where T : class
        {
            _genericoRepositorio.Delete<T>(id);
        }

        public void Delete<T>(T entity) where T : class
        {
            _genericoRepositorio.Delete<T>(entity);
        }
    }
}
