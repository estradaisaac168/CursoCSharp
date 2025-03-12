using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    class CitaMedica
    {
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }  

        public DateTime Fecha { get; set; }

        public CitaMedica(Paciente paciente, Doctor doctor, DateTime fecha)
        {
            Paciente = paciente;
            Doctor = doctor;
            Fecha = fecha;
        }

        public void MostrarCita()
        {
            Console.WriteLine($"Cita: {Paciente.Nombre} con {Doctor.Nombre} el {Fecha}");
        }
    }
}
