using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion9
{
    class TareaUno
    {
        /*
         * 
         * Introducir una cadena de caracteres e indicar si es un palíndromo. 
         * Una palabra palíndroma es aquella que se lee igual adelante que atrás. 
         * Por ejemplo: ojo, rayar, solos.
         * 
         * 
         * 
         * Hacer un programa que le pida al usuario la fecha de su nacimiento, 
         * y nosotros le diremos qué día de la semana era.
         * 
         * 
         * 
         * Modificar ligeramente al programa “Generador de contraseñas” 
         * y a su método “GenerarContraseña” para que haga uso de StringBuilder 
         * en la concatenación de la contraseña que se está generando.
         * 
         */


        #region "Primera forma"
        public void Verificar()
        {
            //Palabra
            string palabra = "solos";


            //Separar cada letra en un array
            char[] letras = palabra.ToCharArray();

            char[] inversionLetras = new char[palabra.Length];

            int index = 0;

            bool palíndroma = false;

            Console.WriteLine(" ");

            //Almacenar en nuevo array pero invirtiendo el array
            for (int i = letras.Count() - 1; i >= 0; i--)
            {
                inversionLetras[index] = letras[i];
                index++;
            }

            Console.WriteLine(" ");

            //Comparar arrays
            for (int i = 0; i < letras.Length; i++)
            {
                if (inversionLetras[i].Equals(letras[i]))
                {
                    palíndroma = true;
                }
                else
                {
                    palíndroma = false;
                    break;
                }
            }

            if (palíndroma) Console.WriteLine($"Es palindromo");
            else Console.WriteLine($"No es palindromo");
        }
        #endregion


        #region "Segunda version mas optimizada"
        public void VerificarDos()
        {
            string palabra = "sombrilla";
            bool palindroma = true;

            for (int i = 0; i < palabra.Length / 2; i++)
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i])
                {
                    palindroma = false;
                    break;
                }
            }

            Console.WriteLine(palindroma ? "Es un palíndromo" : "No es un palíndromo");
        }
        #endregion
    }
}
