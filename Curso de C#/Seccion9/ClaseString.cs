using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion9
{
    class ClaseString
    {
        public void HandlerClass()
        {
            // Metodos para buscar cadenas

            // PadLeft
            // PadRight
            // IsNullOrEmpty
            // IsNullOrWhiteSpace
            // CompareTo

            // Length
            // Clone
            // Copy
            // CopyTo
            // ToCharArray
            // ToCharArray


        }

        public void MethodString()
        {
            // Contains --> Devuelve un valor booleano si la cadena contiene la subcadena
            //string parrafo = "Hola, mi nombre es Juan Perez mas contenido Lorem ipsum dolor sit amet consectetur adipisicing elit. " +
            //                    "Fuga consequatur impedit a est accusantium facere voluptatibus quod quas voluptatem architecto. " +
            //                    "Fugit vero amet corporis quae porro voluptatem ea officiis maiores?";

            //Console.WriteLine(parrafo);

            //Console.Write("\nEscribe la subcadena a buscar: ");
            //string textobuscar = Console.ReadLine();

            //// Contains --> Sensible a mayusculas y minusculas
            //if (parrafo.Contains(textobuscar)) // Si la cadena contiene la subcadena devuelve true
            //{
            //    Console.WriteLine("La cadena contiene la subcadena");
            //}
            //else
            //{
            //    Console.WriteLine("La cadena no contiene la subcadena");
            //}



            // StartsWith --> Devuelve un valor booleano si la cadena empieza con la subcadena
            // EndsWith --> Devuelve un valor booleano si la cadena termina con la subcadena


            //________________________________________________________________________________________________________________________________

            // IndexOf --> Devuelve la posicion de la primera ocurrencia de la subcadena devuelve -1 si no la encuentra
            // LastIndexOf --> Devuelve la posicion de la ultima ocurrencia de la subcadena

            //string palabra = "Pantalla";
            //char caracterBuscado = 'P';

            //// Ambos retornan un -1 si no encuentran la subcadena
            //int index = palabra.IndexOf(caracterBuscado); // Sensibles a mayusculas y minusculas
            //int index2 = palabra.LastIndexOf(caracterBuscado); // Sensibles a mayusculas y minusculas
            //Console.WriteLine("La primera ocurrencia de la letra {0} es en la posicion {1}", caracterBuscado, index);
            //Console.WriteLine("La ultima ocurrencia de la letra {0} es en la posicion {1}", caracterBuscado, index2);


            //________________________________________________________________________________________________________________________________

            //Inmutabilidad de las cadenas
            // Las cadenas son inmutables, es decir, no se pueden modificar una vez creadas

            //string cadena = "Hola Mundo";
            //string cadena2 = cadena; // --> cadena2 apunta a la misma direccion de memoria que cadena

            ////cadena += cadena2; // Concatenamos la cadena2 a la cadena

            //Console.WriteLine(cadena);
            //Console.WriteLine(cadena2);

            //cadena += " desde C#"; // --> Se crea una nueva cadena con la concatenacion de la cadena original y la nueva cadena

            //Console.WriteLine("Despues de la concatenacion");

            //Console.WriteLine(cadena2); // --> cadena2 sigue apuntando a la cadena original
            //Console.WriteLine(cadena); // --> cadena apunta a la nueva cadena 


            //________________________________________________________________________________________________________________________________

            // Trim --> Elimina los espacios en blanco al inicio y al final de la cadena o los caracteres especificados
            // TrimStart --> Elimina los espacios en blanco al inicio de la cadena
            // TrimEnd --> Elimina los espacios en blanco al final de la cadena


            //string cadena1 = "-----Hola Mundo----";
            //string cadena2 = "    Hola Mundo    ";

            //Console.WriteLine("Texto sucio: ", cadena1);
            //Console.WriteLine("Texto con espacios: ", cadena2);

            //Console.WriteLine(cadena1.Trim('-'));
            //Console.WriteLine(cadena2.Trim());


            //________________________________________________________________________________________________________________________________

            // Replace --> Reemplaza una subcadena por otra subcadena

            //Ejemplo con Replace
            //string cadena = "Hola Mundo";
            //string cadenaReemplazada = cadena.Replace("Mundo", "C#");

            //Console.WriteLine(cadena);
            //Console.WriteLine(cadenaReemplazada);

            ////Especificar el rango desde donde se va a reemplazar
            //string cadena2 = "Hola Mundo";
            //string cadenaReemplazada2 = cadena2.Replace("Mundo", "C#", 5, 5); // Reemplaza la subcadena desde la posicion 5 y reemplaza 5 caracteres


            //________________________________________________________________________________________________________________________________


            //StringBuilder

            //StringBuilder es una clase que permite modificar cadenas de texto de manera eficiente
            //bufer de memoria que se puede modificar, a diferencia de las cadenas que son inmutables
            //mas informacion de bufer con StringBuilder 


            //string numeros = "";

            //for (int i = 1; i < 101; i++)
            //{
            //    numeros += i + ", ";
            //}

            //Console.WriteLine(numeros);


            //String y StringBuilder no son compatibles --> StringBuilder.ToString para CAST

            //StringBuilder numeros = new StringBuilder();

            //for (int i = 1; i < 101; i++)
            //{
            //    numeros.Append(i + ", "); //Append() --> info
            //}

            //string cadenaString = numeros.ToString(); //

            //Console.WriteLine(numeros);

            //_________________________________________________________________________-

            // Equals
            // EqualsIgnoreCase

            //Console.Write("Ingrese su email: ");
            //string email = Console.ReadLine();


            //Console.Write("Confirme su email: ");
            //string emailConfirm = Console.ReadLine();

            //bool compareEmail = Equals(email, emailConfirm);

            //if (compareEmail)
            //{
            //    Console.WriteLine("Email aceptado");
            //} else
            //{
            //    Console.WriteLine("Los emails no son iguales");
            //}

            //_________________________________________________________________________-


            //Compare se usa comúnmente con string.
            //Compare para comparar dos cadenas y determinar su orden lexicográfico.

            //string str1 = "apple";
            //string str2 = "banana";

            //int result = string.Compare(str1, str2);

            //if (result < 0)
            //    Console.WriteLine($"{str1} viene antes que {str2}");
            //else if (result > 0)
            //    Console.WriteLine($"{str1} viene después que {str2}");
            //else
            //    Console.WriteLine($"{str1} y {str2} son iguales");


            //_________________________________________________________________________-

            //Extrae una parte de la cadena desde la posición 6, con una longitud de 5.

            string texto = "Hola, mundo!";
            string subcadena = texto.Substring(6, 5); // "mundo"

            Console.WriteLine(subcadena);


            //_________________________________________________________________________-

            //ToLower() convierte el texto a minúsculas.
            //ToUpper() lo convierte a mayúsculas.

            string texto2 = "Hola Mundo";
            Console.WriteLine(texto2.ToLower()); // "hola mundo"
            Console.WriteLine(texto2.ToUpper()); // "HOLA MUNDO"

            //_________________________________________________________________________-

            //Divide la cadena en un array usando , como separador.

            string frase = "manzana,pera,uva";
            string[] frutas = frase.Split(',');

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //_________________________________________________________________________-

            //Concat une varias cadenas en una sola.

            string parte1 = "Hola";
            string parte2 = "Mundo";
            string resultado = string.Concat(parte1, " ", parte2);

            Console.WriteLine(resultado); // "Hola Mundo"

            //_________________________________________________________________________-

            //Format permite insertar valores en una cadena con {0}, {1},

            string nombre = "Carlos";
            int edad = 30;

            string mensaje = string.Format("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
            Console.WriteLine(mensaje);

            //_________________________________________________________________________-

            //Join une elementos de un array en una cadena con un separador.

            string[] palabras = { "Hola", "Mundo", "C#" };
            string resultado2 = string.Join(" - ", palabras);

            Console.WriteLine(resultado2); // "Hola - Mundo - C#"

            //_________________________________________________________________________-


            //PadLeft(10) ajusta la cadena a una longitud de 10 caracteres agregando espacios al inicio.

            string texto3 = "Hola";
            string resultado3 = texto3.PadLeft(10);

            Console.WriteLine("'" + resultado3 + "'"); // '      Hola'


            //_________________________________________________________________________-


            //PadRight(10) ajusta la cadena a una longitud de 10 caracteres, agregando espacios al final.


            string texto4 = "Hola";
            string resultado4 = texto4.PadRight(10);

            Console.WriteLine("'" + resultado4 + "'"); // 'Hola      '

            //PadLeft(10, '-') rellena con -hasta que la cadena tenga 10 caracteres.
            //PadRight(10, '*') rellena con *hasta que la cadena tenga 10 caracteres.


            //string texto = "Hola";
            //string resultadoIzquierda = texto.PadLeft(10, '-'); // "------Hola"
            //string resultadoDerecha = texto.PadRight(10, '*'); // "Hola******"

            //Console.WriteLine(resultadoIzquierda);
            //Console.WriteLine(resultadoDerecha);


            //_________________________________________________________________________-

            // Principales secuencias de escape en C#

            // \n   - Nueva línea
            Console.WriteLine("Hola\nMundo");

            // \t   - Tabulación
            Console.WriteLine("Hola\tMundo");

            // \"   - Comillas dobles dentro de una cadena
            Console.WriteLine("Dijo: \"Hola Mundo\"");

            // \'   - Comilla simple dentro de una cadena
            Console.WriteLine("Es un \'ejemplo\' de comillas simples");

            // \\   - Barra invertida
            Console.WriteLine("Ruta del archivo: C:\\Usuarios\\Documentos");

            // \r   - Retorno de carro (usado en algunos sistemas operativos)
            Console.WriteLine("Hola\rMundo");

            // \b   - Retroceso (borra el carácter anterior)
            Console.WriteLine("Hola\b Mundo");

            // \f   - Salto de página (poco usado)
            Console.WriteLine("Primera\fSegunda");

            // \v   - Tabulación vertical (poco usado)
            Console.WriteLine("Hola\vMundo");

            // Uso de cadena literal con @ para evitar secuencias de escape
            string ruta = @"C:\Usuarios\Documentos\Archivo.txt";
            Console.WriteLine(ruta);


            //_________________________________________________________________________-


            //una cadena interpolada se crea utilizando el prefijo $ antes de una cadena, lo que permite incrustar variables directamente dentro de la cadena usando { }.

            string nombre6 = "Carlos";
            int edad2 = 30;

            // Uso de cadena interpolada con $
            string mensaje6 = $"Hola, mi nombre es {nombre6} y tengo {edad2} años.";

            Console.WriteLine(mensaje6);

            //Interpolación con expresiones y cálculos
            //Puedes hacer cálculos y usar métodos dentro de { }:

            int a = 5, b = 10;
            Console.WriteLine($"La suma de {a} y {b} es {a + b}.");
            Console.WriteLine($"El número en mayúsculas: {"texto".ToUpper()}.");

            //Interpolación con formato de números y fechas

            double precio = 1250.75;
            int cantidad = 3500;
            DateTime fecha = DateTime.Now;

            Console.WriteLine($"Precio: {precio:C}"); // Formato de moneda
            Console.WriteLine($"Fecha: {fecha:dd/MM/yyyy}"); // Formato de fecha
            Console.WriteLine($"Cantidad en miles: {cantidad:N}"); // Formato de miles


            //Interpolación con saltos de línea y tabulación
            string name = "Ana";
            Console.WriteLine($"Nombre:\t{name}\nEdad:\t25");

            //_________________________________________________________________________-


            //dd Día con dos dígitos 05
            //d Día sin ceros iniciales 5
            //dddd Nombre completo del día miércoles
            //MM Mes con dos dígitos 03
            //M Mes sin ceros iniciales 3
            //MMMM Nombre completo del mes marzo
            //yy Año en dos dígitos  25
            //yyyy Año en cuatro dígitos   2025
            //HH Hora en formato 24h 14
            //hh Hora en formato 12h 02
            //mm Minutos 30
            //ss Segundos    15
            //tt AM o PM PM


            //DateTime.Now
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine($"Fecha completa: {fechaActual}");
            Console.WriteLine($"Día: {fechaActual.Day}");
            Console.WriteLine($"Mes: {fechaActual.Month}");
            Console.WriteLine($"Año: {fechaActual.Year}");

            //.ToString("formato")
            DateTime fecha1 = DateTime.Now;

            Console.WriteLine($"Formato corto: {fecha1.ToString("d")}");  // 05/03/2025
            Console.WriteLine($"Formato largo: {fecha1.ToString("D")}");  // miércoles, 5 de marzo de 2025
            Console.WriteLine($"Hora corta: {fecha1.ToString("t")}");     // 14:30
            Console.WriteLine($"Hora larga: {fecha1.ToString("T")}");


            //Formatos personalizados en interpolación de cadenas
            DateTime fecha2 = DateTime.Now;

            Console.WriteLine($"Fecha en formato personalizado: {fecha:dd/MM/yyyy}"); // 05/03/2025
            Console.WriteLine($"Hora en formato 24h: {fecha2:HH:mm:ss}");             // 14:30:15
            Console.WriteLine($"Hora en formato 12h: {fecha2:hh:mm tt}");             // 02:30 PM
            Console.WriteLine($"Día y mes en texto: {fecha2:dddd, MMMM yyyy}");       // miércoles, marzo 2025

            //Conversión de una cadena a DateTime
            string fechaTexto = "05/03/2025";
            DateTime fecha3 = DateTime.ParseExact(fechaTexto, "dd/MM/yyyy", null);

            Console.WriteLine($"Fecha convertida: {fecha3:dddd, MMMM yyyy}"); // miércoles, marzo 2025







        }
    }
}
