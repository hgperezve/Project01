using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IEquipamentoRepositorio : IGenericoRepositorio<Equipamento, decimal>
    {
        IList<EventoEquipamento_View> FindByEventoIdView(decimal eventoId);
        IList<Equipamento> FindExcludeEventoId(decimal eventoId);
    }
}
