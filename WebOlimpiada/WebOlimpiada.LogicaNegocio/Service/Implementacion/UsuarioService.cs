using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Implementacion;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.LogicaNegocio.Service.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private UsuarioRepositorio _usuarioRepositorio;

        public UsuarioService()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public Usuario GetByCodigo(string codigo, string password)
        {
            return _usuarioRepositorio.GetByCode(codigo, password);
        }
    }
}
