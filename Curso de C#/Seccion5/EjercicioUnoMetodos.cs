using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion5
{
    class EjercicioUnoMetodos
    {

        public void StartMetodo()
        {
            Core();
        }

        static decimal GradosRadianes(decimal grados)
        {
            return grados * (decimal)Math.PI / 180;
        }

        static void Core()
        {
            decimal grados = 0M;
            string respuesta = "";

            do
            {
                Console.WriteLine("Introduce los grados: ");
                grados = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("El valor en radianes es: " + GradosRadianes(grados));

                Console.WriteLine("Desea continuar? s/n");
                respuesta = Console.ReadLine();


            } while(respuesta == "s" || respuesta == "S");
        }
    }
}
