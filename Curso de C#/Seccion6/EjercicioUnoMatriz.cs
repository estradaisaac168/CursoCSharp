using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion6
{
    public class EjercicioUnoMatriz
    {
        public void StartMethod()
        {
            byte i, numeroAlumnos;

            double sumaCalificaciones = 0, promedioCalificaciones, calificacionMinima = 10, calificacionMaxima = 0;


            //Pedir la cantidad de alumnos
            Console.WriteLine("Ingrese el numero de alumnos: ");
            numeroAlumnos = Convert.ToByte(Console.ReadLine());


            //Creacion de la matriz y le asignamos el tamaño con la cantidad de alumnos
            double[] calificaciones = new double[numeroAlumnos];

            //Pedir las calificaciones de los alumnos
            for (i = 0; i < numeroAlumnos; i++)
            {
                Console.WriteLine("Ingrese la calificacion del alumno {0}: ", i);
                calificaciones[i] = Convert.ToDouble(Console.ReadLine()); //Alamacena la calificacion en la posicion i

                //Acumular las calificaciones
                sumaCalificaciones += calificaciones[i]; //sumaCalificaciones = sumaCalificaciones + calificaciones[i];
                
            }

            //Calcular el promedio

            promedioCalificaciones = sumaCalificaciones / numeroAlumnos;


            //Calcular la calificacion minima y maxima

            for (i = 0; i < numeroAlumnos; i++)
            {
                if (calificaciones[i] < calificacionMinima)
                {
                    calificacionMinima = calificaciones[i];
                }

                if (calificaciones[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones[i];
                }
            }

            Console.WriteLine("El promedio de las calificaciones es: {0}", promedioCalificaciones);
            Console.WriteLine("La calificacion minima es: {0}", calificacionMinima);
            Console.WriteLine("La calificacion maxima es: {0}", calificacionMaxima);

            Console.ReadKey();
        }
    }
}
