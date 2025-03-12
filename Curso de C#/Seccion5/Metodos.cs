using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion5
{
    class Metodos
    {
        // [MODIFICADOR] - [TIPO] - [NOMBRE] - [PARAMETROS]

        public void StartMetodo()
        {
            Calcular();
            //MostrarTupla();
        }

        static void Calcular()
        {
            decimal num1, num2 = 0M;

            //Agrupamos las variables dentro de una tupla numeros
            (decimal num1, decimal num2, decimal resultado) numeros;
            int option = 0;

            do
            {
                Console.WriteLine("Que tipo de operacion deceas? : ");
                Console.WriteLine("1Sumar? : ");
                Console.WriteLine("2 Restar? : ");
                Console.WriteLine("3 Multiplicar? : ");
                Console.WriteLine("4 Dividir? : ");
                option = Convert.ToInt32(Console.ReadLine());



                switch (option)
                {
                    case 1:
                        //No devuelve un tipo
                        Sumar();
                        break;

                    case 2:
                        //Devuelve un tipo a la tupla numeros
                        numeros = Restar();
                        Console.WriteLine("Seleccionaste una resta : {0} - {1} = {2} ", numeros.num1, numeros.num2, numeros.resultado);
                        //Console.WriteLine("El resultado de la suma es: " + Restar());
                        break;

                    case 3:
                        num1 = CapturarValor("Ingresa el primer numero: ");
                        num2 = CapturarValor("Ingresa el segundo numero: ");
                        Multiplicar(num1, num2);
                        break;

                    case 4:
                        num1 = CapturarValor("Ingresa el primer numero: ");
                        num2 = CapturarValor("Ingresa el segundo numero: ");
                        Console.WriteLine("El resultado de la division es: " + Division(num1, num2));
                        break;

                }

            } while (option < 1 || option > 4);
        }

        static decimal CapturarValor(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Convert.ToDecimal(Console.ReadLine());
        }

        static void Sumar()
        {
            decimal num1, num2, result = 0M;

            Console.WriteLine("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + result);
        }

        // Retornar multiples valores
        static (decimal, decimal, decimal) Restar()
        {
            decimal num1, num2, resultado = 0M;
            num1 = CapturarValor("Ingresa el primer numero: ");
            num2 = CapturarValor("Ingresa el segundo numero: ");
            resultado = num1 - num2;
            return (num1, num2, resultado);
        }

        //static decimal Restar()
        //{
        //    decimal num1, num2 = 0M;
        //    num1 = CapturarValor("Ingresa el primer numero: ");
        //    num2 = CapturarValor("Ingresa el segundo numero: ");
        //    return num1 - num2;

        //}


        static void Multiplicar(decimal num1, decimal num2)
        {
            decimal result = 0M;

            result = num1 * num2;
            Console.WriteLine("El resultado de la suma es: " + result);
        }


        static decimal Division(decimal num1, decimal num2)
        {

            if (num2 != 0)
            {
                return num1 / num2;

            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;

            }
        }


        // Tema sobre ref...
        // Tema sobre out...
        // Tema sobre var... Funciona solamente dentro del metodo en donde se esta trabajando
        // Tema sobre tupla... Sirve para agrupar datos (TIPO) IDENTIFICADOR (VALOR);

       static void MostrarTupla()
        {
            string nombre = "Isaac Estrada";
            int edad = 35;
            decimal estatura = 1.68M;

            //Tupla identificador implicita
            var persona = ("Humberto Mejia", 34, 1.78M);

            var persona2 = (
                Nombre: "Humberto Estrada", 
                Edad: 35, 
                Estatura: 1.78
                );


            //identificador de tipo explicito
            (string nombre, int edad, decimal estatura) persona3 = ("Humberto Estrada", 35, 1.78M);

            //Las tuplas se accede a los elementos por medio de un punto y el numero de la posicion
            Console.WriteLine("Nombre: {0} - Edad: {1}, Estatura: {2}", persona.Item1, persona.Item2, persona.Item3);
            Console.WriteLine("Nombre: {0} - Edad: {1}, Estatura: {2}", persona2.Nombre, persona2.Edad, persona2.Estatura);
        }

    }
}
