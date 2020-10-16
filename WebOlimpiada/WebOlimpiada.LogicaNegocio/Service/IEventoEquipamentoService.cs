using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;
using WebOlimpiada.Dominio45.EntidadesCompuestas;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IEventoEquipamentoService
    {
        //IList<EventoEquipamento> GetAll();
        Evento_Equipamento Create(Evento_Equipamento eventoEquipamento);
        Evento_Equipamento GetByIds(decimal eventoId, decimal equipamentoId);
        Evento_Equipamento Update(Evento_Equipamento eventoEquipamento);
        void Delete(Evento_Equipamento eventoEquipamento);
    }
}
