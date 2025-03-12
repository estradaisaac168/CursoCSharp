using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class Queue
    {

        // Cola
        // FIFO (First In First Out)
        // En una cola, el primer elemento que entra es el primero en salir
        // Metodos
        // Enqueue --> Agregar elementos
        // Dequeue --> Eliminar elementos y devuelve el valor eliminado
        // Peek --> Muestra el primer elemento agregado a la cola
        // Count --> Muestra la cantidad de elementos que tiene la cola
        // Clear --> Elimina todos los elementos de la cola
        // Contains --> Devuelve true si el elemento esta en la cola y false si no esta


        Queue<int> cola = new Queue<int>();

        public Queue() {

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);
        }


        // Agregar elementos
        public void AgregarElemento(int elemento)
        {
            cola.Enqueue(elemento); // Agrega un elemento a la cola
        }

        // Muestra el primer elemento agregado a la cola
        public void MostrarPrimerElemento()
        {
            Console.WriteLine(cola.Peek());
        }


        // Muestra la cantidad de elementos que tiene la cola
        public void MostrarCantidadElementos()
        {
            Console.WriteLine(cola.Count);
        }


        // Muestra todos los elementos de la cola
        public void MostrarElementos()
        {
            foreach (int item in cola)
            {
                Console.WriteLine(item);
            }
        }


        // Elimina todos los elementos de la cola
        public void EliminarElementos()
        {
            cola.Clear();
        }



        // Elimina el primer elemento de la cola
        public void EliminarPrimerElemento()
        {
            cola.Dequeue(); // Elimina el primer elemento de la cola y devuelve el valor eliminado
        }
    }
}
