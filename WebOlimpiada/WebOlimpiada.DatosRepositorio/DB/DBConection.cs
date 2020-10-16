using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOlimpiada.DatosRepositorio.DB
{
    public class DBConection
    {
        private SqlConnection Conexion = new SqlConnection(@"Server=INTEL-PC\SQLEXPRESS;DataBase=SistemTickets;User Id=sa;Password=14122019;");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
