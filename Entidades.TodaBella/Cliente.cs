namespace Entidades.TodaBella
{
    public class Cliente
    {
        public Cliente(int idUsuario, string nombre, string telefono, string domicilio, int edad)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Telefono = telefono;
            Domicilio = domicilio;
            Edad = edad;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public int Edad { get; set; }
    }
}
