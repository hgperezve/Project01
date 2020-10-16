using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IComplejoService
    {
        IList<Complejo> GetAll();
        IList<Complejo> GetBySedeOlimpicaId(decimal pSedeOlimpicaId);
        Complejo Create(Complejo complejo);
        Complejo GetById(decimal id);
        Complejo Update(Complejo complejo);
        void Delete(decimal id);
    }
}
