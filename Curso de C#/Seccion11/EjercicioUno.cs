using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion11
{
    class EjercicioUno
    {
        public void Init()
        {
            int opcion;
            bool repetir = true;
            string mensajeParaCifrar, passwordMensaje, mensajeCifrado;

            MemoryStream memoryStream = new MemoryStream();

            Console.Write("Ingresa el mensaje que deceas cifrar: ");
            mensajeParaCifrar = Console.ReadLine();

            Console.Write("Ingresa la password para proteger el mensaje: ");
            passwordMensaje = Console.ReadLine();

            mensajeCifrado = Mensajecifrado(mensajeParaCifrar);

            byte[] matrizCadenaByte = Encoding.UTF8.GetBytes(mensajeCifrado);

            memoryStream.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            Console.WriteLine("El mensaje esta protegido presiona cualquier tecla para continuar.");
            Console.ReadKey();


            //Empezamos a leer el string (cifrado) almacenado en el memorystream

            byte[] buferBytesLeidos = new byte[100];

            memoryStream.Seek(0, SeekOrigin.Begin);

            //Leer
            memoryStream.Read(buferBytesLeidos, 0, (int)memoryStream.Length);

            string cadenaDecodificadaCifrada = Encoding.UTF8.GetString(buferBytesLeidos);

            do
            {
                Console.Clear();

                Console.WriteLine("1. Mostrar mensaje");
                Console.WriteLine("2. Descifrar mensaje");
                Console.WriteLine("3. Me rindo");

                Console.Write("Selecciona una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Mensaje: \"{cadenaDecodificadaCifrada}\"");
                        Console.WriteLine("El mensaje esta protegido presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Ingresa la password para decifrar el mendaje"); 
                        string posiblePassword = Console.ReadLine();
                        if (posiblePassword == passwordMensaje)
                        {
                            string mensajeDescifrado = DesifrarMensaje(cadenaDecodificadaCifrada);
                            Console.WriteLine($"Mensaje: \"{mensajeDescifrado}\"");
                            Console.WriteLine("El mensaje esta protegido presiona cualquier tecla para continuar.");
                            Console.ReadKey();

                            //Liberar memoria
                            memoryStream.Close();

                            repetir = false;
                        }
                        else
                        {
                            Console.WriteLine("Password incorrecto. Itenta de nuevo..");
                            Console.WriteLine("El mensaje esta protegido presiona cualquier tecla para continuar.");
                            Console.ReadKey();
                        }
                            break;
                    case 3:
                        repetir = false; 
                        break;

                    default:
                        Console.WriteLine(""); break;
                }

            }
            while (repetir);
        }

        static string Mensajecifrado(string mjCifrado)
        {
            string mensajeCifrado;

            mensajeCifrado = mjCifrado;

            mensajeCifrado = mensajeCifrado.Replace('a', '1');
            mensajeCifrado = mensajeCifrado.Replace('e', '2');
            mensajeCifrado = mensajeCifrado.Replace('i', '3');
            mensajeCifrado = mensajeCifrado.Replace('o', '4');
            mensajeCifrado = mensajeCifrado.Replace('u', '5');

            return mensajeCifrado;
        }

        static string DesifrarMensaje(string mjCifrado)
        {

            string mensajeDescifrado;

            mensajeDescifrado = mjCifrado;

            mensajeDescifrado = mensajeDescifrado.Replace('1', 'a');
            mensajeDescifrado = mensajeDescifrado.Replace('2', 'e');
            mensajeDescifrado = mensajeDescifrado.Replace('3', 'i');
            mensajeDescifrado = mensajeDescifrado.Replace('4', 'o');
            mensajeDescifrado = mensajeDescifrado.Replace('5', 'u');

            return mensajeDescifrado;

        }
    }
}
