using ConectarBd;
using System.Data;

namespace AccesoDatos.TodaBella
{
    public class AccesoCliente : IEntidades
    {
        Base b = new Base("localhost", "root", "", "todabella");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminarcliente({0})",
               Entidad.IdUsuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertarcliente(" +
               "{0},'{1}','{2}','{3}',{4})", Entidad.IdUsuario,
               Entidad.Nombre, Entidad.Telefono, Entidad.Domicilio, Entidad.Edad));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call p_mostrarcliente('%{0}%')",
                 filtro), "nombre");
        }
    }
}
