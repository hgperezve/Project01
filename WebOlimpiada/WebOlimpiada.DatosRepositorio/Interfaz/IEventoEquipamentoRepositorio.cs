using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IEventoEquipamentoRepositorio : IGenericoRepositorio<Evento_Equipamento, decimal>
    {
        Evento_Equipamento FindByIds(decimal eventoId, decimal equipamentoId);
    }
}
