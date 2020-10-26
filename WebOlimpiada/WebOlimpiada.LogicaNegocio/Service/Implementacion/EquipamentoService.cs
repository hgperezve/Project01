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
    public class EquipamentoService: GenericoService<Equipamento, decimal>, IEquipamentoService
    {
        public IEquipamentoRepositorio EquipamentoRepositorio
        {
            get { return (IEquipamentoRepositorio)_genericoRepo; }
            set { _genericoRepo = value; }
        }

        public EquipamentoService()
        {
            EquipamentoRepositorio = new EquipamentoRepositorio();
        }

        public IList<EventoEquipamento_View> GetByEventoIdView(decimal eventoId)
        {
            return EquipamentoRepositorio.FindByEventoIdView(eventoId);
        }

        public IList<Equipamento> GetExcludeEventoId(decimal eventoId)
        {
            return EquipamentoRepositorio.FindExcludeEventoId(eventoId);
        }
    }
}
