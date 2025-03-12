using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class Uso_del_While
    {

        public void StartClass()
        {
            byte numero = 1;

            while (numero <= 10)
            {
                Console.WriteLine("numero: {0}", numero );
                numero++;
            }
        }
    }
}
