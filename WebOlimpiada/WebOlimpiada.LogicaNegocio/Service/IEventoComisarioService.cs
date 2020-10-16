using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IEventoComisarioService
    {
        Evento_Comisario Create(Evento_Comisario eventoComisario);
        Evento_Comisario GetByIds(decimal eventoId, decimal comisario);
        Evento_Comisario Update(Evento_Comisario eventoComisario);
        void Delete(Evento_Comisario eventoComisario);
    }
}
