using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curso_de_C_.Seccion8
{
    class ColeccionGenericaList
    {

        //List<T> es una clase genérica que se encuentra en el espacio de nombres System.Collections.Generic
        //List<T> es una colección de elementos de tipo T
        //List<T> es una clase genérica, por lo que se puede crear una lista de cualquier tipo de datos

        List<string> personas = new List<string>();


        //Métodos de la clase List<T>
        //Add(T) -> Agrega un elemento al final de la lista
        public void Agregar(string nombre)
        {
            personas.Add(nombre);
        }

        //Agregar elementos a la lista en una posición específica
        //Insert(int, T) -> Inserta un elemento en la posición especificada
        // Si no hay elementos en la lista, el elemento se inserta en la posición 0 pero se le debe de especificar la posición
        public void Insertar(int posicion = 0, string nombre = "Juan")
        {
            personas.Insert(posicion, nombre);
        }

        //Remover por posición
        //RemoveAt(int) -> Elimina el elemento en la posición especificada
        public void Eliminar(int posicion)
        {
            personas.RemoveAt(posicion);
        }

        //Eliminar elementos de la lista
        //Remove(T) -> Elimina la primera ocurrencia de un elemento específico de la lista
        public void Eliminar(string nombre)
        {
            personas.Remove(nombre);
        }

        //Eliminar todos los elementos de la lista
        //Clear() -> Elimina todos los elementos de la lista
        public void EliminarTodo()
        {
            personas.Clear();
        }

        //Buscar elementos en la lista
        //Contains(T) -> Determina si un elemento está en la lista
        public void Buscar(string nombre)
        {
            if (personas.Contains(nombre))
            {
                Console.WriteLine("El nombre {0} se encuentra en la lista", nombre);
            }
            else
            {
                Console.WriteLine("El nombre {0} no se encuentra en la lista", nombre);
            }
        }

        //Obtener la posición de un elemento en la lista
        //IndexOf(T) -> Devuelve la posición de la primera ocurrencia de un elemento en la lista
        public void Posicion(string nombre)
        {
            int posicion = personas.IndexOf(nombre);
            if (posicion != -1) //Si el elemento no se encuentra en la lista, IndexOf devuelve -1
            {
                Console.WriteLine("El nombre {0} se encuentra en la posición {1}", nombre, posicion);
            }
            else
            {
                Console.WriteLine("El nombre {0} no se encuentra en la lista", nombre);
            }
        }


        //Contar elementos de la lista
        //Count -> Devuelve el número de elementos de la lista
        public void Contar()
        {
            Console.WriteLine("La lista tiene {0} elementos", personas.Count);
        }

        public void Mostrar()
        {
            foreach (string persona in personas)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
