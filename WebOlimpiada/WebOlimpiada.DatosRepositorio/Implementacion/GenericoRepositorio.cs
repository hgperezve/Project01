using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public abstract class GenericoRepositorio<T, IdT> :IGenericoRepositorio<T, IdT>
    {

        public IList<T> FindAll<T>() where T : class
        {
            IList<T> objeto = new List<T>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = (from e in db.Set<T>() select e);

                objeto = lst.ToList<T>();
            }
            return objeto;
        }

        public T Create<T>(T objeto) where T : class
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Set<T>().Add(objeto);
                db.SaveChanges();
            }
            return objeto;
        }

        public T FindById<T>(IdT Id) where T : class
        {
            T objeto;
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                objeto = db.Set<T>().Find(Id);

            }
            return objeto;
        }

        public T Update<T>(T objeto) where T : class
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return objeto;
        }

        public void Delete<T>(IdT id) where T : class
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                T entity = db.Set<T>().Find(id);
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                //T entity = db.Set<T>().Find(id);
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete<T>(decimal id1, decimal id2) where T : class
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                T entity = db.Set<T>().Find(id1,id2);
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }
    }
}
