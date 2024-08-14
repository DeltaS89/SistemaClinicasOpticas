using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAndroid.Components.Model
{
    internal class Model
    {
    }
    
    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
    public class Examen
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Resultado { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
    }

    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }

}
