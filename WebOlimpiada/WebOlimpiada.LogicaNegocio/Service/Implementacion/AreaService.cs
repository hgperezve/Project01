using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class AreaService: IAreaService
    {
        private AreaRepositorio _areaRepositorio;

        public AreaService()
        {
            _areaRepositorio = new AreaRepositorio();
        }

        public IList<Area> GetAll()
        {
            return _areaRepositorio.FindAll();
        }

        public IList<Area> GetByComplejoId(decimal pComplejoId)
        {
            return _areaRepositorio.FindByComplejoId(pComplejoId);
        }

        public Area Create(Area area)
        {
            return _areaRepositorio.Create(area);
        }

        public Area GetById(decimal id)
        {
            return _areaRepositorio.FindById(id);
        }

        public Area Update(Area area)
        {
            return _areaRepositorio.Update(area);
        }

        public void Delete(decimal id)
        {
            _areaRepositorio.Delete(id);
        }
    }
}
