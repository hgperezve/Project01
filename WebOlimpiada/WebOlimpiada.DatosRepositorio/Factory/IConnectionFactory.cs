﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.DatosRepositorio.Factory
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
