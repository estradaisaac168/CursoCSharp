using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class Uso_del_Do_While
    {
        public void StartClass()
        {
            //Para este loop primero se ejecuta el codigo y luego se evalua la condicion
            //Es decir, se ejecuta al menos una vez

            int numero = 0;
            do
            {
                Console.WriteLine("Ingresa un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero != 0);
        }
    }
}
