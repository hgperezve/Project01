using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.Dominio45.EntidadesCompuestas;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class EventoComisarioRepositorio: GenericoRepositorio<Evento_Comisario, decimal>
    {
        public Evento_Comisario FindByIds(decimal eventoId, decimal comisarioId)
        {
            Evento_Comisario Evento_Comisario;
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                Evento_Comisario = db.Evento_Comisario.Where(a => a.EventoId.Equals(eventoId) && a.ComisarioId.Equals(comisarioId)).FirstOrDefault();

            }
            return Evento_Comisario;
        }
    }
}
