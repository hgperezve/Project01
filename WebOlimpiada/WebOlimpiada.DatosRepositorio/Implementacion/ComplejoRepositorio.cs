using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class ComplejoRepositorio
    {
        public IList<Complejo> FindAll()
        {
            IList<Complejo> complejos = new List<Complejo>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = from d in db.Complejo
                          select d;
                complejos = lst.ToList<Complejo>();
            }
            return complejos;
        }

        public IList<Complejo> FindBySedeOlimpicaId(decimal pSedeOlimpicaId)
        {
            IList<Complejo> complejos = new List<Complejo>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = db.Complejo.Where(a => a.SedeOlimpicaId.Equals(pSedeOlimpicaId));

                complejos = lst.ToList<Complejo>();
            }
            return complejos;
        }

        public Complejo Create(Complejo complejo)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Complejo.Add(complejo);
                db.SaveChanges();
            }
            return complejo;
        }

        public Complejo FindById(decimal id)
        {
            Complejo complejo = new Complejo();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                complejo = db.Complejo.Find(id);

            }
            return complejo;
        }

        public Complejo Update(Complejo complejo)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Entry(complejo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return complejo;
        }

        public void Delete(decimal id)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                Complejo complejo = db.Complejo.Find(id);
                db.Complejo.Remove(complejo);
                db.SaveChanges();
            }
        }
    }
}
