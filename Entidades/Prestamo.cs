using System;
using System.ComponentModel.DataAnnotations;

namespace Prestamos_Tarea3.Entidades
{
    public class Prestamo
    {   
        [Key]
        public int PrestamoId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public int PersonaId { get; set; }
        public string Concepto { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
        public double Mora { get; set; }

        public Prestamo()
        {
            PrestamoId = 0;
            FechaPrestamo = DateTime.Now;
            PersonaId = 0;
            Concepto = "";
            Monto = 0.0;
            Balance = 0.0;
            Mora = 0.0;
        }
    }
}