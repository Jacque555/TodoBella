namespace Entidades.TodaBella
{
    public class Agendamiento
    {
        public Agendamiento(int idCita, int fkidUsuario, string hora, string fecha, string servicio)
        {
            IdCita = idCita;
            FkidUsuario = fkidUsuario;
            Hora = hora;
            Fecha = fecha;
            Servicio = servicio;
        }

        public int IdCita { get; set; }
        public int FkidUsuario { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public string Servicio { get; set; }
    }
}
