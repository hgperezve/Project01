using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class EventoRepositorio : GenericoRepositorio<Evento, decimal>
    {
        public IList<Evento> FindByAreaId(decimal pAreaId)
        {
            IList<Evento> eventos = new List<Evento>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var lst = db.Evento.Where(a =>  a.AreaId.Equals(pAreaId));
                try { eventos = lst.ToList<Evento>(); }
                catch (Exception ex
                )
                { }
               
            }
            return eventos;
        }
    }
}
