using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion10
{
    internal class Introduccion
    {
        /*
         * 
         * Las estructuras (struct) en C# son tipos de valor que permiten agrupar datos relacionados, 
         * similares a las clases, pero con diferencias clave en su comportamiento y uso.
         * 
         * 
         * 
         * Características principales
         * 
         * Son tipos de valor → Se almacenan en la pila (stack), no en el heap.
         * No admiten herencia → No pueden heredar de otras estructuras o clases.
         * Pueden implementar interfaces → Pero no heredar de una clase base.
         * Usadas para datos pequeños → Útiles cuando el tamaño del objeto es pequeño y se copian con frecuencia.
         * No pueden tener un constructor sin parámetros definido por el usuario → Siempre hay un constructor predeterminado que inicializa los valores a cero o default.
         *
         */

        List<Cliente> listaCliente = new List<Cliente>();

        public void RegistroClientes(Cliente cliente)
        {
            listaCliente.Add(cliente);
        }


        public void MostrarClientes()
        {
            Console.WriteLine("Listado de Cliente..");

            foreach (var item in listaCliente)
            {
                Console.WriteLine($"Nombre del cliente: {item.nombre}");
                Console.WriteLine($"Edad del cliente: {item.edad}");
                Console.WriteLine($"Direccion del cliente: {item.direccion}");
                Console.WriteLine($"---------------------------------------");
            }
        }
    }

    struct Cliente
    {
        public string nombre;
        public int edad;
        public string direccion;
    }


    #region "Estructuras anidadas separadas ejemplo uno"

    /*
     * 
     * Las estructuras anidadas separadas en C# se refieren a definir una struct dentro de otra struct, pero manteniéndolas organizadas y reutilizables.
     * 
     */

    struct Empleado
    {

    }

    struct Empresa
    {
        Empleado empleado1;
    }

    #endregion



    #region "Estructuras anidadas separadas ejemplo dos"

    struct Cancion
    {
        private string titulo;
        private string artista;
        private int duracion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public int Duracion { get => duracion; set => duracion = value; }


        public override string ToString()
        {
            return $"Título: {titulo}\nArtista: {artista}\nDuración: {duracion} segundos";
        }

    }


    struct ListaReproduccion
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public Cancion cancion1;
        public Cancion cancion2;

        public override string ToString()
        {
            return $"Playlist: {nombre}\nCanción 1: {cancion1}\nCanción 2: {cancion2}";
        }

    }
    #endregion


    struct Persona
    {
        private string nombre;
        private int edad;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"\nnombre: {Nombre}\napellido: {Apellido}\nedad: {Edad}";
        }
    }

}
