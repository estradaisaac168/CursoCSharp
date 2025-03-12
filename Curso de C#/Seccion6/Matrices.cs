using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion6
{
    class Matrices
    {
        public void StartMethod()
        {
            Matriz();
        }


        static void Matriz()
        {
            //Matrices unidimensionales (solo una fila de elementos)
            //[tipo][nombre] = new tipo[tamano]
            int[] array = new int[5]; //Declaracion de un array de 5 elementos

            double[] calificaciones = new double[4] { 9, 10, 5.7, 8 }; //Declaracion de un array de 10 elementos

            string[] nombres = new string[2] { "Isaac", "Humberto" }; //Declaracion de un array de 2 elementos

            int[] numeros;

            numeros = new int[] { 1, 2, 3, 4, 5 }; //Declaracion de un array de 5 elementos
                                                   //

            string[] names = new string[3];

            //names[0] = "Oscar";
            //names[1] = "Sandra";
            //names[2] = "Luis";

            //Asignacion de valores dentro del array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Llenar el array de nombres: {0} ", i);
                names[i] = Console.ReadLine();
            }


            //Acceder a los elementos de una matriz unidimensional
            Console.WriteLine(numeros[3]);

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
