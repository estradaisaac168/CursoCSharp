using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{

    class Alumno
    {
        private int edad;
        public Alumno(int edad)
        {
            this.edad = edad;
        }

        public int Edad
        {
            get => edad;
        }
    }

    class Colecciones<T>
    {
        // Hay 3 tipos de colecciones en C#
        // Genericas
        // No Genericas
        // concurrentes


        //Entre las colecciones genericas tenemos
        // List
        // Dictionary
        // Queue
        // SortedList

        private int i = 0;
        private T[] matrizElementos;


        public Colecciones(int longitud)
        {
            matrizElementos = new T[longitud];
        }

        public void Agregar(T elemento)
        {
            matrizElementos[i] = elemento;
            i++;
        }

        public T Obtener(int posicion)
        {
            return matrizElementos[posicion];
        }

        public void Listar()
        {
            foreach (T elemento in matrizElementos)
            {
                if (elemento != null)
                {
                    Console.WriteLine(elemento);
                }
            }
        }
    }
}
