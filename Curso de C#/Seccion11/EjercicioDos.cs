using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion11
{
    class EjercicioDos
    {
        public void Init()
        {
            //Variable que guardara la ruta a explorar
            string directorio;

            do
            {
                Console.Write("Por favor ingrese la ruta del directorio: ");
                directorio = Console.ReadLine();

                //Verificar si el directorio existe antes de crearlo
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine("La ruta especificada no existe ingrese una ruta valida");
                }
            }
            while (!Directory.Exists(directorio));

            ExplorarDirectorio(directorio);
        }

        static private void ExplorarDirectorio(string directorio)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine($"Contenido de: {directorio}");

                /*
                 * Con este metodo se obtiene todos los archivos y subdirectorios.
                 * 
                 * GetFileSystemEntries()
                 * 
                 */

                string[] archivosSubdirectorios = Directory.GetFileSystemEntries(directorio);

                MostrarTabla(archivosSubdirectorios);

                //Menu
                Console.WriteLine("Ingrese el numero de la opcion mostrada que deceas explorar");
                string opcion = Console.ReadLine();

                if (opcion.ToLower() == "s")
                {
                    continuar = false;
                }
                else if (opcion.ToLower() == "a")
                {
                    directorio = Path.GetDirectoryName(directorio);
                }
                else if (opcion.ToLower() == "n")
                {
                    Console.Clear();

                    Console.Write("Ingrese la nueva ruta: ");
                    string nuevaRuta = Console.ReadLine();

                    if (Directory.Exists(nuevaRuta))
                    {
                        directorio = nuevaRuta;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una ruta valida: ");
                        Console.WriteLine("Ingrese cualquier ruta para continuar......");
                        Console.ReadKey();
                    }
                }
                else if (Convert.ToInt32(opcion) >= 0 && Convert.ToInt32(opcion) < archivosSubdirectorios.Length)
                {
                    int opcionEscogida = Convert.ToInt32(opcion);

                    if (Directory.Exists(archivosSubdirectorios[opcionEscogida]))
                    {
                        directorio = archivosSubdirectorios[opcionEscogida];
                    }
                    else
                    {
                        //
                        Console.WriteLine("Seleccione un directorio valido no un archivo");
                        Console.WriteLine("Presiona cualquier tecla para continuar");

                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida, 'a' para regresar, 's' para salir, 'n' para nueva ruta");
                }
            }
        }

        static private void MostrarTabla(string[] archivosSubdirectorios)
        {
            Console.WriteLine($"{"Indice",-8}{"Nombre",-50}{"Tipo",-13}");
            String guiones = new string('-', 71);
            Console.WriteLine(guiones);

            string nombre, tipo;

            for (int i = 0; i < archivosSubdirectorios.Length; i++)
            {
                nombre = Path.GetFileName(archivosSubdirectorios[i]);

                if (Directory.Exists(archivosSubdirectorios[i]))
                {
                    //entonces el tipo sera un subdirectorio
                    tipo = "Subdirectorio";
                }
                else
                {
                    tipo = Path.GetExtension(archivosSubdirectorios[i]);
                }

                Console.WriteLine($"{i,-8}{nombre,-50}{tipo,-13}");
            }

            Console.WriteLine();
        }
    }
}
