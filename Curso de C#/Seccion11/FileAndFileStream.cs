using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion11
{
    class FileAndFileStream
    {
        /*
         * No se guardan en la memoria sino en archivos fisicos
         * 
         * Create
         * Exists
         * Open
         * Delete
         * Copy
         * Move
         * WriteAllText y ReadAllText
         * 
         * 
         * PROPIEDADES
         * 
         * -> Length
         * -> Position
         * -> CanRead, CanWrite y CanSeek
         * 
         * 
         * METODOS
         * 
         * -> Write
         * -> Read
         * -> Flush
         * -> Seek
         * -> Close
         */


        public void Init()
        {
            //CrearArchivo();
            //LeerArchivo();
            UsoDeFile();
        }


        public void UsoDeFile()
        {
            //FileStream fileStream = File.Create("Archivo creado con File.txt");
            //fileStream.Close();


            //Metodo WriteAllText sin necesidad de usar File.Create();
            //File.WriteAllText("Archivo creado con File.txt", "Este es un texto de prueba usando la clase File");

            #region "Uso de AppendAllText()"
            //Escribir texto o anexar contenido
            //FileStream fileStream = File.Create("Archivo creado con File.txt");

            //byte[] buffer = Encoding.UTF8.GetBytes("Texto de prueba");

            //fileStream.Write(buffer, 0, buffer.Length);

            //fileStream.Close();

            //Inicialmente se crea el archivo y se abre un flujo
            //File.AppendAllText("Archivo creado con File.txt", "Isaac Estrada"); //Este metodo no trunca el texto anterior
            #endregion


            #region "StreamWriter"
            //Se abre el flujo pero se debe cerrar el flujo.
            //FileStream fileStream = File.Create("Archivo creado con File.txt");
            //fileStream.Close();

            //StreamWriter fileWriter = new StreamWriter("Archivo creado con File.txt");
            //fileWriter.Write("Seguimos con las pruebas");

            /*
             * al colocar true como segundo parametro se anexa el contido
             * al colocar false se sobre escribe
             */
            //StreamWriter fileWriter = new StreamWriter("Archivo creado con File.txt", false);
            //fileWriter.WriteLine("Texto anexado");
            //fileWriter.Close();
            #endregion


            #region "StreamReader"
            //StreamReader streamReader = new StreamReader("password.txt");
            //string passwordArchivo = streamReader.ReadLine();
            //Console.WriteLine($"Password: {passwordArchivo} ");
            //streamReader.Close();
            #endregion

            #region "Uso de using"
            //string passwordArchivo;
            //using (StreamReader streamReader = new StreamReader("password.txt"))
            //{
            //   passwordArchivo = streamReader.ReadLine();
            //}
            //Console.WriteLine($"Password: {passwordArchivo} ");
            #endregion


            #region "Copiar, Mover, Eliminar, Verificar si existe un file"
            if (File.Exists("C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt"))
            {
                Console.WriteLine("El archivo existe");

                //string origenArchivo = "testMoverFile.txt";
                //string destinoArchivo = "C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt";

                //File.Copy(origenArchivo, destinoArchivo, true); //Copiar
                //File.Move(origenArchivo, destinoArchivo); //mover

                //Eliminar
                //File.Delete("C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt");


            }
            else
            {
                Console.WriteLine("No se encontro el archivo");
            }
            #endregion


            #region "Directorios"
            /*
             * Metodos de la clase
             * 
             * -> CreateDirectory
             * -> Exist
             * -> GetFiles y GetDirectories
             * -> Move
             * -> Delete
             * 
             */

            #endregion

        }


        public void CrearArchivo()
        {

            //Recibe dos parametros la ruta absoluta,

            //FileStream fileStream = new FileStream("C:\\Users\\Isaac_Estrada\\Desktop\\testingC#.txt", FileMode.Create);
            FileStream fileStream = new FileStream("testingC#.txt", FileMode.Create);


            //Escribir texto en el archivo
            string textoPrueba = "Este es texto de prueba del curso C#";

            byte[] bufferCadenaBytes;

            bufferCadenaBytes = Encoding.UTF8.GetBytes(textoPrueba);

            fileStream.Write(bufferCadenaBytes, 0, bufferCadenaBytes.Length);


            //Leer informacion desde un archivo
            fileStream.Close();


        }

        public void LeerArchivo()
        {
            FileStream fileStream = new FileStream("testingC#.txt", FileMode.Open);

            byte[] bufferLeerArchivo = new byte[1024];

            fileStream.Read(bufferLeerArchivo, 0 , bufferLeerArchivo.Length);

            string cadenaDecodificada = Encoding.UTF8.GetString(bufferLeerArchivo);

            Console.WriteLine($"Este es el texto dentro del archivo: {cadenaDecodificada}");

            fileStream.Close();
        }
    }
}
