using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IComisarioService
    {
        IList<Comisario> GetAll();
        Comisario Create(Comisario comisario);
        Comisario GetById(decimal id);
        Comisario Update(Comisario comisario);
        void Delete(decimal id);
        IList<EventoComisario_View> GetByEventoId(decimal eventoId);
    }
}
