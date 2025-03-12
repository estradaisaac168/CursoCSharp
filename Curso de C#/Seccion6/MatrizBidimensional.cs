using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion6
{
    class MatrizBidimensional
    {
        public void Init()
        {
            //Declaracion de matriz de 2 dimensiones 1 forma
            int[,] ints = new int[3, 3] { {2,2,3}, {2,4,3},{4,4,4} };

            // 2 forma
            //int[,] ints = { {2,2,3}, {2,4,3},{4,4,4} };



            //Declaracion de una matriz 3 dimensiones
            double[,,] matriz = new double[2, 2, 3] { { {2,3,56},{3,6,3} },{ {3,7,3},{3,9,3} } };


            for (int x = 0; x < 2; x++)
            {

                for (int y = 0; y < 2; y++)
                {

                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write($"Fila:  {x}, Columna:  {y}, Profundidad:  {z} --->");

                        Console.WriteLine($"{matriz[x,y,z]}");
                    }
                }
            }

        }
    }
}
