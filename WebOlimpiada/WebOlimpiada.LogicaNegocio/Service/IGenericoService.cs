using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IGenericoService <T, IdT>
    {
        IList<T> GetAll<T>() where T : class;
        T Create<T>(T entity) where T : class;
        T GetById<T>(IdT id) where T : class;
        T Update<T>(T entity) where T : class;
        void Delete<T>(IdT id) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}
