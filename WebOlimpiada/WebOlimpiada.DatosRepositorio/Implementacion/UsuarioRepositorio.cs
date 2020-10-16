using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Modelos;

namespace WebOlimpiada.DatosRepositorio.Implementacion
{
    public class UsuarioRepositorio
    {
        public Usuario GetByCode(string codigo, string password)
        {
            Usuario usuario;
            using (OlimpiadaDBEntities db = new OlimpiadaDBEntities())
            {
                usuario = db.Usuario.Where(a=>a.Codigo.Equals(codigo) && a.Password.Equals(password)).FirstOrDefault();

            }
            return usuario;
        }
    }
}
