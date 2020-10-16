using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IAreaService
    {
        IList<Area> GetAll();
        IList<Area> GetByComplejoId(decimal pComplejoId);
        Area Create(Area area);
        Area GetById(decimal id);
        Area Update(Area area);
        void Delete(decimal id);
    }
}
