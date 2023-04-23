namespace Entidades.TodaBella
{
    public class Cliente
    {
        public Cliente(int idUsuario, string nombre, string telefono)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Telefono = telefono;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
