using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prestamos_Tarea3.Entidades
{
    public class MorasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public double Valor { get; set; }

        public MorasDetalle()
        {
            Id = 0;
            MoraId = 0;
            PrestamoId = 0;
            Valor = 0.0;
        }

        public MorasDetalle(int IdMora, int IdPrestamo, double Monto)
        {
            MoraId = IdMora;
            PrestamoId = IdPrestamo;
            Valor = Monto;
        }
    }
}
