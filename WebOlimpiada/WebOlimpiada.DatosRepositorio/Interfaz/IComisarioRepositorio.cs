using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IComisarioRepositorio : IGenericoRepositorio<Comisario, decimal>
    {
        IList<EventoComisario_View> FindByEventoId(decimal eventoId);
    }
}
