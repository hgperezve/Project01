using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IGenericoRepositorio<T, IdT>
    {
        IList<T> FindAll<T>() where T : class;
        T Create<T>(T objeto) where T : class;
        T FindById<T>(IdT Id) where T : class;
        T Update<T>(T objeto) where T : class;
        void Delete<T>(IdT id) where T : class;
        void Delete<T>(T entity) where T : class;
        void Delete<T>(decimal id1, decimal id2) where T : class;
    }
}
