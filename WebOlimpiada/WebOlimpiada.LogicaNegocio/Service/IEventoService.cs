using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IEventoService
    {
        IList<Evento> GetAll();
        Evento Create(Evento evento);
        Evento GetById(decimal id);
        Evento Update(Evento evento);
        void Delete(decimal id);
        IList<Evento> GetByAreaId(decimal pAreaId);
    }
}
