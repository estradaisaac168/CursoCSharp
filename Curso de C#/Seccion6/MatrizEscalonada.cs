using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion6
{
    class MatrizEscalonada
    {
        public void Init()
        {
            //double[][] dimension = new double[3][];

            //dimension[0] = new double[3];
            //dimension[1] = new double[4]; 
            //dimension[2] = new double[1];
            //dimension[3] = new double[5];

            //Inicializar

            //dimension[0] = new double[3] {2,3,5};
            //dimension[1] = new double[4] {4,6,3,7};
            //dimension[2] = new double[1] {1};
            //dimension[3] = new double[5] {4,5,6,3,0};

            double[][] dimension = new double[][]
            {
                new double[] {2,3,5 },
                new double[] {4,6,3,7},
                new double[] {1},
                new double[] {4,5,6,3,0}
            };

            double[][] dimension2 = 
            {
                new double[] {2,3,5 },
                new double[] {4,6,3,7},
                new double[] {1},
                new double[] {4,5,6,3,0}
            };

            for (int i = 0; i < dimension2.Length; i++)
            {
                for (int j = 0; j < dimension2[i].Length; j++)
                {
                    Console.WriteLine($"Valores: {dimension2[i][j]}");
                }
            }

        }
    }
}
