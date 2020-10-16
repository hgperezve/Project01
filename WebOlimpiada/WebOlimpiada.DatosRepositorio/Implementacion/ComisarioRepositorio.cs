using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class ComisarioRepositorio : GenericoRepositorio<Comisario, decimal>
    {
        public IList<EventoComisario_View> FindByEventoId(decimal eventoId)
        {
            IList<EventoComisario_View> comisarioByEvento = new List<EventoComisario_View>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = db.EventoComisario_View.Where(a => a.EventoId.Equals(eventoId));
                try { comisarioByEvento = lst.ToList<EventoComisario_View>(); }
                catch (Exception ex
                )
                { }

            }
            return comisarioByEvento;
        }
    }
}
