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
                        /*
                         * MENU
                         * 
                         * Copiar
                         * Mover
                         * Eliminar
                         * Renombrar
                         */

                        //En el else -if que nos permite escoger un numero de índice, 
                        //vamos a permitir que al escoger un archivo se nos muestre un menú
                        //con las opciones mencionadas anteriormente, 
                        //esto reemplazará el mensaje de “selecciona un directorio, no un archivo”.

                        OperacionesArchivos(archivosSubdirectorios[opcionEscogida]);

                        //Console.WriteLine("Seleccione un directorio valido no un archivo");
                        //Console.WriteLine("Presiona cualquier tecla para continuar");

                        //Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida, 'a' para regresar, 's' para salir, 'n' para nueva ruta");
                }
            }
        }

        private static void OperacionesArchivos(string archivo)
        {

            string nombreArchivo, rutaCopiarArchivo, rutaMoverArchivo, destinoArchivo, respuestaReemplazo, respuestaEliminar, respuestaRenombrar, nuevoNombreArchivo, rutaArchivoRenombrado, rutaArchivo;

            nombreArchivo = Path.GetFileName(archivo);
            rutaArchivo = archivo;

            Console.Clear();

            Console.WriteLine($"Seleccionaste el archivo: [{nombreArchivo}]");

            Console.WriteLine("\nOpciones disponibles para los archivos: ");
            Console.WriteLine("\n1 - Copiar archivo");
            Console.WriteLine("2 - Mover archivo");
            Console.WriteLine("3 - Eliminar archivo");
            Console.WriteLine("4 - Renombrar archivo");
            Console.WriteLine("5 - Salir");

            Console.Write("Que opcion deceas realizar?? ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Nombre del archivo seleccionado: {nombreArchivo}");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la ruta donde decea - Copiar archivo");
                    rutaCopiarArchivo = Console.ReadLine();

                    if (Directory.Exists(rutaCopiarArchivo))
                    {
                        destinoArchivo = Path.Combine(rutaCopiarArchivo, nombreArchivo);

                        if (!File.Exists(destinoArchivo))
                        {
                            File.Copy(rutaArchivo, destinoArchivo);

                            MensajeExito("Copiado");
                        }
                        else
                        {
                            Console.Write($"\nEl archivo [{nombreArchivo}] ya existe en la ruta de destino: Deseas reemplazarlo? (s/n)");
                            respuestaReemplazo = Console.ReadLine();

                            if (respuestaReemplazo.ToLower() == "s")
                            {
                                File.Copy(rutaArchivo, destinoArchivo, true); //True es sobre escribir e archivo


                                MensajeExito("Reemplazado");
                            }
                            else
                            {
                                MensajeRutaNoValida();
                            }
                        }
                    }
                    else
                    {
                        MensajeRutaNoValida();
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese la ruta donde decea - Mover el archivo");
                    rutaMoverArchivo = Console.ReadLine();

                    if (Directory.Exists(rutaMoverArchivo))
                    {
                        destinoArchivo = Path.Combine(rutaMoverArchivo, nombreArchivo);

                        if (File.Exists(destinoArchivo))
                        {
                            File.Move(rutaArchivo, rutaMoverArchivo);

                            MensajeExito("Movido");
                        }
                        else
                        {
                            Console.Write($"\nEl archivo [{nombreArchivo}] ya existe en la ruta de destino: Deseas reemplazarlo? (s/n)");
                            respuestaReemplazo = Console.ReadLine();

                            if (respuestaReemplazo.ToLower() == "s")
                            {
                                File.Delete(rutaArchivo);

                                File.Move(rutaArchivo, rutaMoverArchivo);


                                MensajeExito("Reemplazarlo");
                            }
                            else
                            {
                                MensajeRutaNoValida();
                            }
                        }
                    }
                    else
                    {
                        MensajeRutaNoValida();
                    }
                    break;

                case 3:
                    Console.Write($"\nEsta seguro de borrar el archivo? (s/n)");
                    respuestaEliminar = Console.ReadLine();

                    if (respuestaEliminar.ToLower() == "s")
                    {
                        File.Delete(rutaArchivo);

                        MensajeExito("Borrado");
                    }
                    else
                    {
                        MensajeRutaNoValida();
                    }
                    break;

                case 4:
                    Console.Write($"\nIngrese el nuevo nombre del archivo (con extension)");
                    nuevoNombreArchivo = Console.ReadLine();

                    Console.Write($"\nEl nuevo nombre de [{nombreArchivo}] sera: [{nuevoNombreArchivo}] (s/n)");
                    respuestaRenombrar = Console.ReadLine();

                    if (respuestaRenombrar.ToLower() == "s")
                    {
                        rutaArchivoRenombrado = Path.Combine(Path.GetDirectoryName(rutaArchivo), nuevoNombreArchivo);

                        File.Move(rutaArchivo, rutaArchivoRenombrado);

                        MensajeExito("Renombrado");
                    }
                    else
                    {
                        MensajeRutaNoValida();
                    }
                    break;

                case 5:
                    Console.WriteLine("\n5 - Salir");
                    Console.WriteLine("Presiona cualquier tecla para continuar");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("\nSelecciona una opcion valida por favor o presiona salir para continuar");
                    Console.WriteLine("Presiona cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
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


        static void MensajeRutaNoValida()
        {
            Console.WriteLine("Ingresa una ruta valida");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MensajeExito(string mensaje)
        {

            Console.WriteLine($"El archivo se ha {mensaje} con exito");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
