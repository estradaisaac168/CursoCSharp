using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class EjercicioUnoConDictionary
    {
        int opcion;
        string nombre;
        long telefono;

        Dictionary<string, long> agenda = new Dictionary<string, long>();

        public void Handler()
        {
            do
            {
                Console.Clear();

                //Menu
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar todos los contactos");
                Console.WriteLine("5. Actualizar contacto");
                Console.WriteLine("6. Salir");

                Console.Write("\nSelecciona una Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Telefono: ");
                        telefono = Convert.ToInt64(Console.ReadLine());
                        agenda.Add(nombre, telefono);
                        Console.WriteLine("\nContacto ({0}) agregado", nombre);
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Buscar contacto por nombre");
                        Console.Write("\nNombre: ");
                        nombre = Console.ReadLine();
                        if (agenda.ContainsKey(nombre))
                        {
                            Console.WriteLine("Nombre: {0}, Telefono: {1}", nombre, agenda[nombre]);
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Eliminar contacto por nombre");
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        if (agenda.ContainsKey(nombre))
                        {
                            agenda.Remove(nombre);
                            Console.WriteLine("Contacto eliminado");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Contactos");
                        foreach (var contacto in agenda)
                        {
                            Console.WriteLine("Nombre: {0}, Telefono: {1}", contacto.Key, contacto.Value);
                        }
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:

                        Console.WriteLine("Actualizar contacto por nombre");
                        Console.Write("\nNombre del contacto que decea actualizar: ");
                        nombre = Console.ReadLine();

                        if (agenda.ContainsKey(nombre))
                        {
                            Console.Write("Nuevo nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            Console.Write("Nuevo telefono: ");
                            long nuevoTelefono = Convert.ToInt64(Console.ReadLine());
                            agenda.Remove(nombre);
                            agenda.Add(nuevoNombre, nuevoTelefono);
                            Console.WriteLine("Contacto actualizado");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }
                        Console.Write("\nPresiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                }


            }
            while (opcion >= 1 && opcion <= 5);
        }
    }
}
