using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.Dominio45.EntidadesCompuestas;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class EventoEquipamentoRepositorio :GenericoRepositorio<Evento_Equipamento, decimal>, IEventoEquipamentoRepositorio
    {
        public Evento_Equipamento FindByIds(decimal eventoId, decimal equipamentoId)
        {
            Evento_Equipamento Evento_Equipamento;
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                Evento_Equipamento = db.Evento_Equipamento.Where(a => a.EventoId.Equals(eventoId) && a.EquipamentoId.Equals(equipamentoId)).FirstOrDefault();

            }
            return Evento_Equipamento;
        }
    }
}
