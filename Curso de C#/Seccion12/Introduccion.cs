﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion12
{
    class Introduccion
    {
        /*
         * 
         * OBJETIVOS
         * 
         * Identificar y corregir errores
         * Mejorar la capacidad y fiabilidad
         * Optimizar el rendimiento
         * Comprender el flujo de ejecucion
         * Aprender de los erores
         * 
         */

        public void Init()
        {
            //Operacion();
            Menu();
        }

        public void Operacion()
        {

            int a = 5;
            int b = 10;
            int c = 0;
            int resultado = 0;

            try
            {
                resultado = a / c; //Division
                Console.WriteLine($"El resultado de {a}/{b} es: {resultado}");
            }
            catch
            {
                Console.WriteLine($"No se puede dividir un numero entre 0");
            }


            resultado = a + b; //Suma

            MostrarSuma(resultado);

        }

        public void MostrarSuma(int resultado)
        {
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }

        public void Menu()
        {
            int opcion = 0;

            Console.WriteLine("Calculadora");


            do
            {
                Console.WriteLine("\nSumar");
                Console.WriteLine("Restar");

                Console.Write("\nSeleccione una opcion dentro del menu: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("\nSolo es posible ingresar numeros entre 1 y 2");

                    opcion = 5;
                }
            }
            while (opcion != 1 && opcion != 2);
        }
    }
}
