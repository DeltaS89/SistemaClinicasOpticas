using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ProyectoFinalAPI.Model
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }
    }

    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especialidad { get; set; }
    }

    public class Examen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Resultado { get; set; }

        [ForeignKey("Paciente")]
        [Required]
        public int PacienteId { get; set; }

        [ForeignKey("Doctor")]
        [Required]
        public int DoctorId { get; set; }
    }

}
