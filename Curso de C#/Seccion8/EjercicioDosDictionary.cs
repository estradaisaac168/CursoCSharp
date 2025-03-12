
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class EjercicioDosDictionary
    {
        //Crear un programa que simule una app bancaria sencilla,
        //y que nos permita tres cosas:


        double gasto, monto, suma;
        int opcion;
        bool salir = true;

        Stack<double> banco = new Stack<double>();


        public void Handler()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Selecciona una opcion del menu");
                Console.WriteLine("1. Agregar gasto");
                Console.WriteLine("2. Mostrar gastos");
                Console.WriteLine("3. Salir");

                Console.Write("\nSelecciona una Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                switch (opcion)
                {
                    case 1:

                        Console.Write("Agrega el primer gasto: ");
                        monto = Convert.ToDouble(Console.ReadLine());

                        AgregarGasto(monto);

                        Console.WriteLine("Gasto {0} agregado con exito:", MostrarMonto());
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        salir = false;
                        break;

                    case 2:
                        Console.WriteLine("Mostrando gastos");
                        if (Count() > 0)
                        {
                            MostrarGastos();

                            Console.WriteLine("Total gastos realizados: {0} ", TotalGastos());
                        }
                        else
                        {
                            Console.WriteLine("No hay gastos por mostrar");
                        }
                        salir = false;
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        salir = true;
                        break;

                    default:
                        salir = true;
                        break;
                }

            }
            while (!salir);

        }

        //Ingresar un gasto
        public void AgregarGasto(double gasto)
        {
            banco.Push(gasto);

        }


        public double MostrarMonto()
        {
            return banco.Peek();
        }


        public int Count()
        {
            return banco.Count();
        }

        //Mostrarnos todos los gastos que hemos hecho,
        //empezando por el último
        public void MostrarGastos()
        {
            int i = banco.Count();

            foreach (var item in banco)
            {
                Console.WriteLine("Gasto: {0} = {1} ", i, item);
                i--;
            }
        }



        //Sumar todos los gastos hechos y mostrarnos el monto que
        // debemos pagar(pago para no generar intereses)
        public double TotalGastos()
        {
            foreach (var item in banco)
            {
                suma +=item;
            }

            return suma;
        }
    }
}
