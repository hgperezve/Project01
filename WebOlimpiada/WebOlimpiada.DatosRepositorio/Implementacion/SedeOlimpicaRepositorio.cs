using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WebOlimpiada.Dominio45.Entidades;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class SedeOlimpicaRepositorio
    {
        public IList<SedeOlimpica> FindAll()
        {
            IList<SedeOlimpica> sedes = new List<SedeOlimpica>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = from d in db.SedeOlimpica
                          select d;
                sedes = lst.ToList<SedeOlimpica>();
            }
            return sedes;
        }

        public SedeOlimpica Create(SedeOlimpica sedeOlimpica)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.SedeOlimpica.Add(sedeOlimpica);
                db.SaveChanges();
            }
            return sedeOlimpica;
        }

        public SedeOlimpica FindById(decimal sedeOlimpicaId)
        {
            SedeOlimpica sedeOlimpica = new SedeOlimpica();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                sedeOlimpica = db.SedeOlimpica.Find(sedeOlimpicaId);
                
            }
            return sedeOlimpica;
        }

        public SedeOlimpica Update(SedeOlimpica sedeOlimpica)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Entry(sedeOlimpica).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return sedeOlimpica;
        }

        public void Delete(decimal id)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                SedeOlimpica sedeOlimpica = db.SedeOlimpica.Find(id);
                db.SedeOlimpica.Remove(sedeOlimpica);
                db.SaveChanges();
            }
        }
    }
}
