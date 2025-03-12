using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class Ejercicio_While
    {
        public void StartEjercicioWhile()
        {
            //Pedir una contraseña y verificar que sea correcta.
            //Si no es correcta, pedir la contraseña nuevamente.

            string password, password2 = "";

            Console.WriteLine("Ingrese la contraseña: ");
            password = Console.ReadLine();

            while (password != password2)
            {
                Console.WriteLine("Ingrese la contraseña nuevamente: ");
                password2 = Console.ReadLine();
            }

            Console.WriteLine("Contraseña correcta");
        }
    }
}
