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
    public class AreaService : GenericoService<Area, decimal>, IAreaService
    {
        public IAreaRepositorio AreaRepositorio
        {
            get { return (IAreaRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }

        public AreaService()
        {
            AreaRepositorio = new AreaRepositorio();
        }

        public IList<Area> GetByComplejoId(decimal pComplejoId)
        {
            return AreaRepositorio.FindByComplejoId(pComplejoId);
        }
    }
}
