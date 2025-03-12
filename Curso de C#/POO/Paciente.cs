using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    class Paciente : Persona
    {
        public string NumeroHistorial { get; set; }
        public List<string> ExpedienteMedico { get; set; } = new List<string>();

        public Paciente(string nombre, int edad,string numeroHistorial) : base(nombre, edad)
        {
            NumeroHistorial = numeroHistorial;
        }


        /// <summary>
        /// Metodo utilizado para agregar diagnosticos medicos
        /// </summary>
        /// <param name="diagnostico">Recibe parametro de tipo string</param>
        public void AgregarDiagnostico(string diagnostico)
        {
            ExpedienteMedico.Add(diagnostico);
        }


        public void MostrarDiagnosticos()
        {
            Console.WriteLine($"Listado de diagnostico para {Nombre}:");

            foreach (var expediente in ExpedienteMedico)
            {
                Console.WriteLine(expediente);
            }
        }


        public override void MostrarInformacion()
        {
            Console.WriteLine($"Paciente: {Nombre}, Edad: {Edad}, Historial: {NumeroHistorial}");
        }
    }
}
