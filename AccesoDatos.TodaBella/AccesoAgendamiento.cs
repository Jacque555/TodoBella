using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;


namespace AccesoDatos.TodaBella
{
    public class AccesoAgendamiento : IEntidades
    {
        Base b = new Base("localhost", "root", "", "todabella");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminaragendamiento({0})",
               Entidad.IdCita));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertaragendamiento(" +
               "{0},{1},'{2}','{3}','{4}')", Entidad.IdCita,
               Entidad.FkidUsuario, Entidad.Hora, Entidad.Fecha, Entidad.Servicio));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call p_mostraragendamiento('%{0}%')",
                 filtro), "fkidUsuario");
        }
    }
}
