using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class AreaRepositorio
    {
        public IList<Area> FindAll()
        {
            IList<Area> areas = new List<Area>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = from d in db.Area
                          select d;
                areas = lst.ToList<Area>();
            }
            return areas;
        }

        public IList<Area> FindByComplejoId(decimal pComplejoId)
        {
            IList<Area> areas = new List<Area>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = db.Area.Where(a => a.ComplejoId.Equals(pComplejoId));

                areas = lst.ToList<Area>();
            }
            return areas;
        }

        public Area Create(Area area)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Area.Add(area);
                db.SaveChanges();
            }
            return area;
        }

        public Area FindById(decimal id)
        {
            Area area = new Area();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                area = db.Area.Find(id);

            }
            return area;
        }

        public Area Update(Area area)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                db.Entry(area).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return area;
        }

        public void Delete(decimal id)
        {
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {

                Area area = db.Area.Find(id);
                db.Area.Remove(area);
                db.SaveChanges();
            }
        }
    }
}
