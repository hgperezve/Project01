using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class EquipamentoRepositorio : GenericoRepositorio<Equipamento, decimal>, IEquipamentoRepositorio
    {
        public IList<EventoEquipamento_View> FindByEventoIdView(decimal eventoId)
        {
            IList<EventoEquipamento_View> equiposPorEvento = new List<EventoEquipamento_View>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var list = db.EventoEquipamento_View.Where(a=>a.EventoId.Equals(eventoId));
                equiposPorEvento = list.ToList<EventoEquipamento_View>();
            }
            return equiposPorEvento;
        }

        public IList<Equipamento> FindExcludeEventoId(decimal eventoId)
        {
            IList<Equipamento> equipos = new List<Equipamento>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                var subselect = (from b in db.Evento_Equipamento where b.EventoId.Equals( eventoId) select b.EquipamentoId ).ToList();
                var result = from c in db.Equipamento where !subselect.Contains(c.EquipamentoId) select c;
                equipos = result.ToList<Equipamento>();
            }
            return equipos;
        }
    }
}
