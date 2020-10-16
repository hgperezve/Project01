using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class SedeOlimpicaService : ISedeOlimpicaService
    {
        private SedeOlimpicaRepositorio _sedeOlimpicaRepositorio;

        public SedeOlimpicaService()
        {
            _sedeOlimpicaRepositorio = new SedeOlimpicaRepositorio();
        }

        public IList<SedeOlimpica> GetAll()
        {
            return _sedeOlimpicaRepositorio.FindAll();
        }

        public SedeOlimpica Create(SedeOlimpica sedeOlimpica)
        {
            return _sedeOlimpicaRepositorio.Create(sedeOlimpica);
        }

        public SedeOlimpica GetById(decimal id)
        {
            return _sedeOlimpicaRepositorio.FindById(id);
        }

        public SedeOlimpica Update(SedeOlimpica sedeOlimpica)
        {
            return _sedeOlimpicaRepositorio.Update(sedeOlimpica);
        }

        public void Delete(decimal id)
        {
            _sedeOlimpicaRepositorio.Delete(id);
        }

    }
}
