using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class EquipamentoRepositorio : GenericoRepositorio<Equipamento, decimal>
    {
        public IList<Equipamento> FindByEventoId(decimal eventoId)
        {
            IList<Equipamento> equipos = new List<Equipamento>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                //equipos = db.Equipamento.Where(a => a.Codigo.Equals(codigo) && a.Password.Equals(password));

            }
            return equipos;
        }

        public IList<EventoEquipamento_View> FindByEventoIdView(decimal eventoId)
        {
            IList<EventoEquipamento_View> equiposPorEvento = new List<EventoEquipamento_View>();
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                //equipos = db.Equipamento.Where(a => a.Codigo.Equals(codigo) && a.Password.Equals(password));
                var list = db.EventoEquipamento_View.Where(a=>a.EventoId.Equals(eventoId));
                equiposPorEvento = list.ToList<EventoEquipamento_View>();
            }
            return equiposPorEvento;
        }
    }
}
