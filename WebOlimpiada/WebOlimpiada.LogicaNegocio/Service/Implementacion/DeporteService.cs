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
    public class DeporteService: GenericoService<Deporte, decimal>, IDeporteService
    {
        public IDeporteRepositorio DeporteRepositorio
        {
            get { return (IDeporteRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }

        public DeporteService()
        {
            DeporteRepositorio = new DeporteRepositorio();
        }

    }
}
