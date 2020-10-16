using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
   public  class ComisarioService: IComisarioService
    {
        private ComisarioRepositorio _comisarioRepositorio;

        public ComisarioService()
        {
            _comisarioRepositorio = new ComisarioRepositorio();
        }

        public IList<Comisario> GetAll()
        {
            return _comisarioRepositorio.FindAll<Comisario>();
        }

        public Comisario Create(Comisario comisario)
        {
            return _comisarioRepositorio.Create<Comisario>(comisario);
        }

        public Comisario GetById(decimal id)
        {
            return _comisarioRepositorio.FindById<Comisario>(id);
        }

        public Comisario Update(Comisario comisario)
        {
            return _comisarioRepositorio.Update<Comisario>(comisario);
        }

        public void Delete(decimal id)
        {
            _comisarioRepositorio.Delete<Comisario>(id);
        }
    }
}
