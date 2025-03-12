using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class Stack
    {

        //Stack (pila)
        //LIFO --> Primero en entrar primero en salir.
        //Push --> Agregar elementos
        //Pop --> Eliminar elementos y devuelve el valor eliminado
        //Peek --> Muestra el ultimo elemento agregado a la pila (stack)
        //Count --> Muestra la cantidad de elementos que tiene la pila (stack)
        //Clear --> Elimina todos los elementos de la pila (stack)
        //Contains --> Devuelve true si el elemento esta en la pila (stack) y false si no esta


        Stack<int> pila = new Stack<int>();

        public Stack()
        {
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
        }

        public void AgregarElemento(int elemento)
        {
            pila.Push(elemento); //Agrega un elemento a la pila (stack) en la posicion 0
        }


        //Muestra el ultimo elemento agregado a la pila (stack)
        //Si se quiere mostrar el primer elemento agregado a la pila (stack) se debe usar el metodo Peek
        public void MostrarElementos()
        {
            foreach (int item in pila)
            {
                Console.WriteLine(item);
            }
        }


        //Muestra el primer elemento agregado a la pila (stack)
        public void MostrarPrimerElemento()
        {
            Console.WriteLine(pila.Peek());
        }


        //Muestra la cantidad de elementos que tiene la pila (stack)
        public void MostrarCantidadElementos()
        {
            Console.WriteLine(pila.Count);
        }

        //Elimina todos los elementos de la pila (stack)
        public void EliminarElementos()
        {
            pila.Clear();
        }


        //Elimina el ultimo elemento agregado a la pila (stack)
        public void EliminarElemento()
        {
            pila.Pop(); //Elimina el ultimo elemento agregado a la pila (stack) y devuelve el valor eliminado
        }

        //indice de un elemento
        public void IndiceElemento(int elemento)
        {
            Console.WriteLine(pila.Contains(elemento));
        }

    }
}
