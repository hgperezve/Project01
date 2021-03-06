﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service
{
    public interface IAreaService: IGenericoService<Area, decimal>
    {
        IList<Area> GetByComplejoId(decimal pComplejoId);
    }
}
