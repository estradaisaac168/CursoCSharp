using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class Segundo_ejercicio_para_for
    {
        public void StartFactorial()
        {
            ulong i, numero, factorial = 1;

            Console.WriteLine("Ingrese un numero para calcular su factorial: ");

            numero = Convert.ToUInt64(Console.ReadLine());

            for (i = numero; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
        }
    }
}
