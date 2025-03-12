using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion8
{
    class Dictionary
    {

        //Dictionary es una coleccion de pares de clave y valor
        //No se pueden repetir las claves
        //Se puede acceder a los elementos por la clave
        //Se puede acceder a los elementos por el indice
        //Metodos
        //Add --> Agregar elementos
        //Remove --> Eliminar elementos
        //Clear --> Eliminar todos los elementos
        //ContainsKey --> Devuelve true si la clave esta en el diccionario y false si no esta
        //ContainsValue --> Devuelve true si el valor esta en el diccionario y false si no esta
        //Count --> Muestra la cantidad de elementos que tiene el diccionario
        //TryGetValue --> Devuelve el valor de la clave especificada
        //Keys --> Devuelve todas las claves del diccionario
        //Values --> Devuelve todos los valores del diccionario


        //int = clave, string = valor
        Dictionary<int, string> diccionario = new Dictionary<int, string>();

        public Dictionary() {

            diccionario.Add(1, "Lunes");
            diccionario.Add(2, "Martes");
            diccionario.Add(3, "Miercoles");
            diccionario.Add(4, "Jueves");
            diccionario.Add(5, "Viernes");
        }


        //Agregar elementos
        public void AgregarElemento(int clave, string valor)
        {
            diccionario.Add(clave, valor);
        }


        //item[] sino existe la clave la agrega, si existe la clave la actualiza
        public void AgregarElemento2(int clave, string valor)
        {
            diccionario[clave] = valor; //eje: diccionario[1] = "Lunes"
        }

        //item[clave] funciona como get
        public void ObtenerElemento(int clave)
        {
            Console.WriteLine(diccionario[clave]); //eje: Console.WriteLine(diccionario[1]);
        }

        //Eliminar elementos
        public void EliminarElemento(int clave)
        {
            diccionario.Remove(clave);  //Elimina el elemento con la clave especificada
        }


        //Eliminar todos los elementos
        public void EliminarElementos()
        {
            diccionario.Clear();
        }


        //Devuelve true si la clave esta en el diccionario y false si no esta
        public void ContieneClave(int clave)
        {
            Console.WriteLine(diccionario.ContainsKey(clave)); //Devuelve true si la clave esta en el diccionario y false si no esta
        }


        //Devuelve true si el valor esta en el diccionario y false si no esta
        public void ContieneValor(string valor)
        {
            Console.WriteLine(diccionario.ContainsValue(valor)); //Devuelve true si el valor esta en el diccionario y false si no esta
        }


        //Muestra la cantidad de elementos que tiene el diccionario
        public void MostrarCantidadElementos()
        {
            Console.WriteLine(diccionario.Count);
        }


        //Devuelve el valor de la clave especificada
        public void MostrarValor(int clave)
        {
            string valor = "";
            diccionario.TryGetValue(clave, out valor);
            Console.WriteLine(valor);
        }



        //Muestra todas las claves del diccionario
        public void MostrarClaves()
        {
            foreach (int item in diccionario.Keys)
            {
                Console.WriteLine(item);
            }
        }



        //Muestra todos los valores del diccionario
        public void MostrarValores()
        {
            foreach (string item in diccionario.Values)
            {
                Console.WriteLine(item);
            }
        }

        //KeyValuePair es una estructura que representa un par clave-valor
        public void MostrarElementos()
        {
            foreach (KeyValuePair<int, string> item in diccionario)
            {
                Console.WriteLine("Clave: " + item.Key + " Valor: " + item.Value);
            }
        }
    }
}
