using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class Ejercicio_Do_While
    {
        public void StartEjercicio_Do_While()
        {
            //Para este loop primero se ejecuta el codigo y luego se evalua la condicion
            //Es decir, se ejecuta al menos una vez
            decimal num1, num2, result = 0M;
            int option = 0;

            do
            {
                Console.WriteLine("Que tipo de operacion deceas? : ");
                Console.WriteLine("1Sumar? : ");
                Console.WriteLine("2 Restar? : ");
                Console.WriteLine("3 Multiplicar? : ");
                Console.WriteLine("4 Dividir? : ");
                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el primer numero: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: " + result);
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es: " + result);
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("El resultado de la division es: " + result);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                        break;

                }

            } while (option < 1 || option > 4);
        }
    }
}
