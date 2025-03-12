using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class IteracionAnidadas
    {
        public void IteracionAnidada()
        {
            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla del {0}", i);

                for (int j = 1; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, result );
                }
            }

            Console.ReadKey();
        }

    }
}
