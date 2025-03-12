using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion10
{
    internal class EjerciciosEstructura
    {
        public void Init()
        {
            Biblicoteca biblicoteca = new Biblicoteca();
            //biblicoteca.MostrarLibros();
            biblicoteca.AgregarLibro();
            biblicoteca.MostrarLibros();
            biblicoteca.Eliminar();
            biblicoteca.MostrarLibros();
        }
    }


    class Biblicoteca
    {
        int cantidadLibro;
        string buscarLibro;
        bool libroEncontrado;
        int posicionLibroEliminar;

        string titulo, autor, anio;


        List<Libro> libros = new List<Libro>();
        public void AgregarLibro()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese informacion para el libro: {cantidadLibro + 1}\n");

            Console.WriteLine("Ingresa el nombre del libro: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del autor: ");
            autor = Console.ReadLine();

            Console.WriteLine("Ingresa el anio de publicacion: ");
            anio = Console.ReadLine();

            libros.Add(new Libro { Titulo = titulo, Autor = autor, Anio = anio });

            Console.Clear();
            Console.WriteLine($"Libro agregado correctamente");
        }


        public void MostrarLibros()
        {
            Console.Clear();

            if (libros.Count() == 0)
            {
                Console.WriteLine("Biblioteca esta vacia, agrega libros para poder visualizar libros");
            }
            else
            {
                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.ToString());
                }


                Console.WriteLine($"Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }


        public void BuscarLibro()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese el nombre exacto del libro: ");
            buscarLibro = Console.ReadLine();

            libroEncontrado = false;

            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(buscarLibro))
                {
                    Console.WriteLine($"\nEl libro: \"{libro.Titulo}\" del autor : \"{libro.Autor}\" se encuentra disponible en la biblioteca en el indice: {libros.IndexOf(libro)}");
                    libroEncontrado = true;
                }
            }

            if (!libroEncontrado)
            {
                Console.WriteLine($"Libro no encontrado");
            }
        }


        public void BuscarParcial()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese al menos una parte del titulo o autor para buscar el libro: ");
            buscarLibro = Console.ReadLine().ToLower();

            libroEncontrado = false;

            foreach (var libro in libros)
            {
                if (libro.Titulo.ToLower().Contains(buscarLibro) || libro.Autor.ToLower().Contains(buscarLibro))
                {
                    Console.WriteLine($"\nLa palabra que buscaste es: {buscarLibro} y el libro enoconrado es: \"{libro.Titulo}\" del autor : \"{libro.Autor}\" se encuentra disponible en la biblioteca en el indice: {libros.IndexOf(libro)}");
                    libroEncontrado = true;
                }
            }

            if (!libroEncontrado)
            {
                Console.WriteLine($"Libro no encontrado");
            }
        }


        public void Eliminar()
        {
            Console.Clear();

            if (libros.Count() == 0)
            {
                Console.WriteLine("No hay nada que eliminar");

            }
            else
            {
                Console.WriteLine("Ingrese el numero del libro que decea eliminar: ");
                posicionLibroEliminar = Convert.ToInt32(Console.ReadLine());

                if (posicionLibroEliminar >= 0 && posicionLibroEliminar < libros.Count())
                {
                    Console.WriteLine($"El libro que deceas eliminar es {libros[posicionLibroEliminar].Titulo} deceas eliminarlo?: si/no ");
                    string opcion = Console.ReadLine();

                    if (opcion == "si")
                    {
                        libros.RemoveAt(posicionLibroEliminar);
                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada");
                    }
                }
                else
                {
                    Console.WriteLine("El numero del libro no es valido");
                }
            }

        }
    }

    struct Libro
    {
        string titulo;
        string autor;
        string anio;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Anio { get => anio; set => anio = value; }

        public override string ToString()
        {
            return $"\nTitulo: {Titulo}\nAutor: {Autor}\nAnio: {Anio}";
        }
    }
}
