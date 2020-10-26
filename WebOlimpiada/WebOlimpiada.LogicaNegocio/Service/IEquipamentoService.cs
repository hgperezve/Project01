using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IEquipamentoService: IGenericoService<Equipamento, decimal>
    {
        IList<EventoEquipamento_View> GetByEventoIdView(decimal eventoId);
        IList<Equipamento> GetExcludeEventoId(decimal eventoId);
    }
}
