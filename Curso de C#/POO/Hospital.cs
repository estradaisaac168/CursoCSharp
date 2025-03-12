using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    class Hospital
    {
        private List<Persona> personas = new List<Persona>();
        private List<CitaMedica> citas = new List<CitaMedica>();

        public event Action<string> Notificar;

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
            Console.WriteLine("Persona aniadida al hospital");
        }

        public void AgendarCita(Paciente paciente, Doctor doctor, DateTime fecha)
        {
            var cita = new CitaMedica(paciente, doctor, fecha);
            citas.Add(cita);
            Notificar?.Invoke($"Nueva cita programada: {paciente.Nombre} con {doctor.Nombre} el {fecha}");
        }


        public void MostrarCitas()
        {
            Console.WriteLine("Lista de citas medicas");

            foreach (var cita in citas)
            {
                cita.MostrarCita();
            }
        }


        public void MostrarPersonas()
        {
            Console.WriteLine("Listado de personas");

            foreach (var persona in personas)
            {
                persona.MostrarInformacion();
            }
        }



    }
}
