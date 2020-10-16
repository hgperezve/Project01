using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.Dominio45.EntidadesCompuestas;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EventoEquipamentoService: IEventoEquipamentoService
    {
        private EventoEquipamentoRepositorio _eventoEquipamentoRepositorio;

        public EventoEquipamentoService()
        {
            _eventoEquipamentoRepositorio = new EventoEquipamentoRepositorio();
        }

        //public IList<EventoEquipamento> GetAll()
        //{
        //    return _eventoEquipamentoRepositorio.FindAll<EventoEquipamento>();
        //}

        public Evento_Equipamento Create(Evento_Equipamento eventoEquipamento)
        {
            return _eventoEquipamentoRepositorio.Create<Evento_Equipamento>(eventoEquipamento);
        }

        public Evento_Equipamento GetByIds(decimal eventoId, decimal equipamentoId)
        {
            return _eventoEquipamentoRepositorio.FindByIds(eventoId, equipamentoId);
        }

        public Evento_Equipamento Update(Evento_Equipamento eventoEquipamento)
        {
            return _eventoEquipamentoRepositorio.Update<Evento_Equipamento>(eventoEquipamento);
        }

        public void Delete(decimal id)
        {
            _eventoEquipamentoRepositorio.Delete<Evento_Equipamento>(id);
        }
    }
}
