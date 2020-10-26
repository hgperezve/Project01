using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class ComplejoRepositorio : GenericoRepositorio<Complejo, decimal>, IComplejoRepositorio
    {

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
    }
}
