using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Interfaz
{
    public interface IComplejoRepositorio : IGenericoRepositorio<Complejo, decimal>
    {
        IList<Complejo> FindBySedeOlimpicaId(decimal pSedeOlimpicaId);
    }
}
