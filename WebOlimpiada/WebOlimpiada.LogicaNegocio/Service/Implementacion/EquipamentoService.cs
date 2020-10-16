using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class EquipamentoService: IEquipamentoService
    {
        private EquipamentoRepositorio _equpiamentoRepositorio;

        public EquipamentoService()
        {
            _equpiamentoRepositorio = new EquipamentoRepositorio();
        }

        public IList<Equipamento> GetAll()
        {
            return _equpiamentoRepositorio.FindAll<Equipamento>();
        }

        public Equipamento Create(Equipamento equipamento)
        {
            return _equpiamentoRepositorio.Create<Equipamento>(equipamento);
        }

        public Equipamento GetById(decimal id)
        {
            return _equpiamentoRepositorio.FindById<Equipamento>(id);
        }

        public Equipamento Update(Equipamento equipamento)
        {
            return _equpiamentoRepositorio.Update<Equipamento>(equipamento);
        }

        public void Delete(decimal id)
        {
            _equpiamentoRepositorio.Delete<Equipamento>(id);
        }

        public IList<EventoEquipamento_View> GetByEventoIdView(decimal eventoId)
        {
            return  _equpiamentoRepositorio.FindByEventoIdView(eventoId);
        }
    }
}
