using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.POO
{
    abstract class Persona : IUsuario
    {
        /*
         * No son necesarias los atributos explicitos 
         * 
         * porque no se ocuparan para realizar otra operacion.
         * 
         */

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad) { 
            Nombre = nombre;
            Edad = edad;
        }


        /// <summary>
        /// Método abstracto que debe ser implementado por las clases derivadas
        /// para mostrar la información de la persona
        /// </summary>
        public abstract void MostrarInformacion();
    }
}
