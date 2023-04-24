using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TodaBella
{
    public class Citas
    {
        public Citas(int idFolio, int fkidUsuario, int pago, string tipoPago)
        {
            IdFolio = idFolio;
            FkidUsuario = fkidUsuario;
            Pago = pago;
            TipoPago = tipoPago;
        }

        public int IdFolio { get; set; }
        public int FkidUsuario { get; set; }
        public int Pago { get; set; }
        public string TipoPago { get; set; }
    }
}
