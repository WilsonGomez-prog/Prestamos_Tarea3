using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prestamos_Tarea3.Entidades
{
    public class Moras
    {   [Key]
        public int MoraId { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }

        [ForeignKey("MoraId")]
        public List<MorasDetalle> DetalleMora { get; set; }

        public Moras()
        {
            MoraId = 0;
            Fecha = DateTime.Now;
            Total = 0.0;

            DetalleMora = new List<MorasDetalle>();
        }

        public Moras(int Id, string FechaMora, double Monto)
        {
            MoraId = Id;
            Fecha = Convert.ToDateTime(FechaMora);
            Total = Monto;

            DetalleMora = new List<MorasDetalle>();
        }
    }
}
