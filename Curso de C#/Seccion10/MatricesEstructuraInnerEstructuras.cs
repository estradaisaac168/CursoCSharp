using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion10
{
    internal class MatricesEstructuraInnerEstructuras
    {
        public void Init()
        {

            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Isaac";
            estudiante.Apellido = "Estrada";


            List<Calificacion> calificacion = new List<Calificacion>()
            {
                new Calificacion {Materia = "Sociales", Puntaje = 9},
                new Calificacion {Materia = "Ingles", Puntaje = 10},
                new Calificacion {Materia = "Lenguaje", Puntaje = 6}
            };

            estudiante.Calificaciones = calificacion;

            Console.WriteLine(estudiante.ToString());

            foreach (var item in estudiante.Calificaciones)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }

    struct Calificacion
    {
        string materia;
        double puntaje;

        public string Materia { get => materia; set => materia = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }

        public override string ToString()
        {
            return $"\nMateria: {Materia}\nPuntaje: {Puntaje}";
        }
    }

    struct Estudiante
    {
        string nombre;
        string apellido;

        List<Calificacion> calificaciones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        internal List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }


        public override string ToString()
        {
            return $"\nnombre: {Nombre}\nApellido: {Apellido}";
        }
    }
}
