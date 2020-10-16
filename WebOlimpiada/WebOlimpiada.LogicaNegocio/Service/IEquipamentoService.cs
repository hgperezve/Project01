using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IEquipamentoService
    {
        IList<Equipamento> GetAll();
        Equipamento Create(Equipamento equpamento);
        Equipamento GetById(decimal id);
        Equipamento Update(Equipamento equipamento);
        void Delete(decimal id);

        IList<EventoEquipamento_View> GetByEventoIdView(decimal eventoId);
    }
}
