using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion4
{
    class EjerciciosSeccion4
    {
       // Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.
       public void CalcularPotencia()
        {
            int numero = 0;
            int exponente = 0;
            int resultado = 0;

            Console.WriteLine("Ingresa el numero que deceas sacar la potencia: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            resultado = (int)Math.Pow(numero, exponente);
            Console.WriteLine("El resultado de la potencia es: ", resultado);
        }

        // Hacer un programa que calcule los números primos que existen entre el 1 y el 100
        public void CalcularNumerosPrimos()
        {
            int numero, divisor, cantidadDivisor = 0;

            //Un bucle que recorra los 100 numero
            for (numero = 2; numero <= 100; numero++)
            {
                //Verificar si es divisible por dos
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        //Aumentar la cantidad de numeros primos
                        cantidadDivisor += 1;
                    }

                }

                if (cantidadDivisor <= 2)
                {
                    Console.WriteLine("El numero {0} es primo", numero);
                }

                cantidadDivisor = 0;

                //Console.WriteLine("La cantidad de numeros primos es de {0} : ", cantidadDivisor);
            }
        }

    }
}
