using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    class Doctor : Persona
    {
        public string Especialidad { get; set; }


        public Doctor(string nombre, int edad, string especialidad) : base(nombre, edad)
        {
            Especialidad = especialidad;
        }


        public override void MostrarInformacion()
        {
            Console.WriteLine($"Doctor: {Nombre}, Edad: {Edad}, Especialidad: {Especialidad}");
        }
    }
}
