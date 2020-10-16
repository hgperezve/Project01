using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface ISedeOlimpicaService
    {
        IList<SedeOlimpica> GetAll();
        SedeOlimpica Create(SedeOlimpica sedeOlimpica);
        SedeOlimpica GetById(decimal id);
        SedeOlimpica Update(SedeOlimpica sedeOlimpica);
        void Delete(decimal id);
    }
}
