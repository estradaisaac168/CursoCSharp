using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion5
{
    class EjercicioDosMetodos
    {
        public void StartMetodo()
        {
            Core();
        }


        static void Core()
        {
            //Formula calcular area Círculo: A=πr^2
            //Formula calcular area Cuadrado: A=l^2
            //Formula calcular area Triángulo: A=(b⋅h/2)

            

            SolicitarDatos();

        }

        //Metodo para solicitar los datos  del usuario
        static void SolicitarDatos()
        {
            string respuesta = "";
            int figura = 0;

            (decimal radio, decimal pi, decimal resultado) circulo = (0, 0, 0);
            (decimal lado, decimal resultado) cuadrado = (0, 0);
            (decimal mibase, decimal altura, decimal resultado) triangulo = (0, 0, 0);

            do
            {
                figura = MostrarMenu();

                switch (figura)
                {
                    case 1:
                        decimal radio = CapturarValor("Introduce el radio del círculo: ");
                        circulo = CalcularAreaCirculo(radio);
                        Console.WriteLine("El área del círculo es: A = π * r^2 = ({0} * {1}^2 = {2}) ", circulo.pi, circulo.radio, circulo.resultado);
                        break;
                    case 2:
                        decimal lado = CapturarValor("Introduce el lado del cuadrado: ");
                        cuadrado = CalcularAreaCuadrado(lado);
                        Console.WriteLine("El área del cuadrado es: A = l^2 = {0}^2 = {1}", cuadrado.lado, cuadrado.resultado);
                        break;
                    case 3:
                        decimal mibase = CapturarValor("Introduce la base del triángulo: ");
                        decimal altura = CapturarValor("Introduce la altura del triángulo: ");
                        triangulo = CalcularAreaTriangulo(mibase, altura);
                        Console.WriteLine("El área del triángulo es: A = (b * h) / 2 = ({0} * {1}) / 2 = {2}", triangulo.mibase, triangulo.altura, triangulo.resultado);
                        break;
                    default:
                //        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine("Desea continuar? s/n");
                respuesta = Console.ReadLine();
            } while (respuesta == "s" || respuesta == "S");
        }

        //Mostrar menu
        static int MostrarMenu()
        {
            Console.WriteLine("Introduce la figura a la que deseas calcular el área: ");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo");
            return Convert.ToInt32(Console.ReadLine());
        }


        static decimal CapturarValor(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Convert.ToDecimal(Console.ReadLine());
        }

        //Metodo calcular area circulo
        static (decimal, decimal, decimal) CalcularAreaCirculo(decimal radio)
        {
            decimal resultado = (decimal)Math.PI * (radio * radio);

            return (radio, (decimal)Math.PI, resultado);
        }

        static (decimal, decimal) CalcularAreaCuadrado(decimal lado)
        {
            decimal resultado = lado * lado;
            return (lado, resultado);
        }

        static (decimal, decimal, decimal) CalcularAreaTriangulo(decimal mibase, decimal altura)
        {
            decimal resultado = (mibase * altura) / 2;
            return (mibase, altura, resultado);
        }
    }
}
