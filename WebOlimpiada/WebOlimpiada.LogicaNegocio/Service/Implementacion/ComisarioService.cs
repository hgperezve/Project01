using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Interfaz;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
   public  class ComisarioService: GenericoService<Comisario, decimal>, IComisarioService
    {
        public IComisarioRepositorio ComisarioRepositorio
        {
            get { return (IComisarioRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }

        public ComisarioService()
        {
            ComisarioRepositorio = new ComisarioRepositorio();
        }

        public IList<EventoComisario_View> GetByEventoId(decimal eventoId)
        {
            return ComisarioRepositorio.FindByEventoId(eventoId);
        }

   }
}
