using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class ComplejoService : IComplejoService
    {
        private ComplejoRepositorio _complejoRepositorio;

        public ComplejoService()
        {
            _complejoRepositorio = new ComplejoRepositorio();
        }

        public IList<Complejo> GetAll()
        {
            return _complejoRepositorio.FindAll();
        }

        public IList<Complejo> GetBySedeOlimpicaId(decimal pSedeOlimpicaId)
        {
            return _complejoRepositorio.FindBySedeOlimpicaId(pSedeOlimpicaId);
        }

        public Complejo Create(Complejo sedeOlimpica)
        {
            return _complejoRepositorio.Create(sedeOlimpica);
        }

        public Complejo GetById(decimal id)
        {
            return _complejoRepositorio.FindById(id);
        }

        public Complejo Update(Complejo complejo)
        {
            return _complejoRepositorio.Update(complejo);
        }

        public void Delete(decimal id)
        {
            _complejoRepositorio.Delete(id);
        }
    }
}
