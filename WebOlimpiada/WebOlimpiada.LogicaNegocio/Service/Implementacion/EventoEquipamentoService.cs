using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.Dominio45.EntidadesCompuestas;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EventoEquipamentoService: GenericoService<Evento_Equipamento, decimal>, IEventoEquipamentoService
    {
        //private EventoEquipamentoRepositorio _eventoEquipamentoRepositorio;
        public IEventoEquipamentoRepositorio EventoEquipamentoRepositorio
        {
            get { return (IEventoEquipamentoRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }
        public EventoEquipamentoService()
        {
            EventoEquipamentoRepositorio = new EventoEquipamentoRepositorio();
        }

 
        //public Evento_Equipamento Create(Evento_Equipamento eventoEquipamento)
        //{
        //    return _eventoEquipamentoRepositorio.Create<Evento_Equipamento>(eventoEquipamento);
        //}

        public Evento_Equipamento GetByIds(decimal eventoId, decimal equipamentoId)
        {
            return EventoEquipamentoRepositorio.FindByIds(eventoId, equipamentoId);
        }

        //public Evento_Equipamento Update(Evento_Equipamento eventoEquipamento)
        //{
        //    return _eventoEquipamentoRepositorio.Update<Evento_Equipamento>(eventoEquipamento);
        //}

        //public void Delete(Evento_Equipamento eventoEquipamento)
        //{
        //    _eventoEquipamentoRepositorio.Delete<Evento_Equipamento>(eventoEquipamento.EventoId, eventoEquipamento.EquipamentoId);
        //}
    }
}
