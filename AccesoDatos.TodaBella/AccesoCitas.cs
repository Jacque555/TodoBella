using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatos.TodaBella
{
    public class AccesoCitas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "todabella");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminarcita({0})",
               Entidad.IdCita));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertarcitas(" +
                "{0},{1},{2},'{3}')", Entidad.IdFolio,
               Entidad.FkidUsuario, Entidad.Pago, Entidad.TipoPago));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call p_mostrarcita('%{0}%')",
                 filtro), "tipoPago");
        }
    }
}
