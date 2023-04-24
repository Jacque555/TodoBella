using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TodaBella
{
    public class Agendamiento
    {
        public Agendamiento(int idCita, string servicio, string hora, string fecha, int fkidUsuario)
        {
            IdCita = idCita;
            Servicio = servicio;
            Hora = hora;
            Fecha = fecha;
            FkidUsuario = fkidUsuario;
        }

        public int IdCita { get; set; }
        public string Servicio { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public int FkidUsuario { get; set; }
    }
}
