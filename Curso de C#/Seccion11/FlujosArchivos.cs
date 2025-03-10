using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curso_de_C_.Seccion11
{
    class FlujosArchivos
    {
        //MemoryStream Class

        //Instancia de MemoryStream

        MemoryStream memoryStream = new MemoryStream();

        public void Init()
        {
            InformacionStream(memoryStream);

            Console.WriteLine("Ingresa texto para guardarlo en stream: ");
            string textoGuardar = Console.ReadLine();

            //Convertir la cadena a bytes
            byte[] matrizCadenaBytes;

            /*
             * 
             * Codificar: string -> Secuencia de bytes
             * 
             * Decodificar: secuencia de bytes -> string
             * 
             */

            matrizCadenaBytes = Encoding.UTF8.GetBytes(textoGuardar);


            //Escribiendo datos en el flujo
            memoryStream.Write(matrizCadenaBytes, 0, matrizCadenaBytes.Length);


            InformacionStream(memoryStream);

            //Seeck() -> Establece la posición dentro de la secuencia actual en el valor especificado.

            //memoryStream.Seek(0, SeekOrigin.Begin);

            //Lectura de flujos

            byte[] buferBytesLeidos = new byte[100];

            memoryStream.Seek(0, SeekOrigin.Begin);

            int bytesLeidos = memoryStream.Read(buferBytesLeidos, 0, (int)memoryStream.Length);

            Console.Write($"bytes: {bytesLeidos}");

            //Decodificar un flujo
            string cadenaDecodificada = Encoding.UTF8.GetString(buferBytesLeidos);

            Console.Write($"\nInformacion decodificada : {cadenaDecodificada}");


            //Cerrar el flujo -> Liberar memoria
            memoryStream.Close();

        }

        static void InformacionStream(MemoryStream memoryStream)
        {
            /*
             * 
             *  Capacidad
             * 
             * Longitud
             * 
             * Posicion
             *
             */

            Console.WriteLine($"La capacidad del stream es: {memoryStream.Capacity} bytes");
            Console.WriteLine($"La Longitud del stream es: {memoryStream.Length} bytes");
            Console.WriteLine($"La Posicion actual del stream es: {memoryStream.Position} bytes");
        }


    }
}
