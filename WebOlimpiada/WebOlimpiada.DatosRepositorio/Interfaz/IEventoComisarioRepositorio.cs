using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IEventoComisarioRepositorio : IGenericoRepositorio<Evento_Comisario, decimal>
    {
        Evento_Comisario FindByIds(decimal eventoId, decimal comisarioId);
    }
}
