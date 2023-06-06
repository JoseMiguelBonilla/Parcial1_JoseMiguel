using System.ComponentModel.DataAnnotations;

namespace Parcial1_JoseMiguel.Models
{
    public class Ingresos
    {
        [Key]

        public int IngresoId {get;set;}
        [Required(ErrorMessage = "La fecha es requerida")]
        public int Fecha{get;set;}
        [Required(ErrorMessage = "El concepto es requerido ")]
        public string? Concepto {get;set;}
        [Required(ErrorMessage = "El monto es requerido")]
        public int Monto {get;set;}


    }
}