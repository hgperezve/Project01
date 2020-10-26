using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class AreaRepositorio : GenericoRepositorio<Area, decimal>, IAreaRepositorio
    {

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
    }
}
