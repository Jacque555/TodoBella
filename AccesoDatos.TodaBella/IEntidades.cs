using System.Data;

namespace AccesoDatos.TodaBella
{
    public interface IEntidades
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
