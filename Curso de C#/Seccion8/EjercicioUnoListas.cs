using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class EjercicioUnoListas
    {
        int opcion, indice;
        string alumno;

        List<string> alumnos = new List<string>();


       public void Administrar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Agregar alumno");
                Console.WriteLine("2.- Eliminar alumno");
                Console.WriteLine("3.- Buscar alumno");
                Console.WriteLine("4.- Mostrar alumnos");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();
                        alumnos.Add(alumno);
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el nombre del alumno a eliminar: ");
                        alumno = Console.ReadLine();
                        indice = alumnos.IndexOf(alumno);
                        if (indice > alumno.Count() || indice < 0)
                        {
                            Console.WriteLine("El alumno {0} no se encuentra en la lista", alumno);
                        }
                        else
                        {
                            alumnos.RemoveAt(indice);
                            Console.WriteLine("El alumno {0} ha sido eliminado", alumno);
                        }
                        Console.Write("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        //alumnos.Remove(alumno);
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el nombre del alumno a buscar: ");
                        alumno = Console.ReadLine();
                        if (alumnos.Contains(alumno))
                        {
                            indice = alumnos.IndexOf(alumno);
                            Console.WriteLine("El alumno {0} se encuentra en la posición {1}", alumno, indice++);
                        }
                        else
                        {
                            Console.WriteLine("El alumno {0} no se encuentra en la lista", alumno);
                        }
                        Console.Write("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        int i = 1;
                        Console.WriteLine("Lista de alumnos: ");
                        foreach (string a in alumnos)
                        {
                            Console.WriteLine("{0}, {1}", i++, a);
                        }
                        Console.Write("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion >=1 && opcion <= 5);
        }
    }
}
