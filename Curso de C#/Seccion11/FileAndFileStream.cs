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
            //if (File.Exists("C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt"))
            //{
            //    Console.WriteLine("El archivo existe");

            //    //string origenArchivo = "testMoverFile.txt";
            //    //string destinoArchivo = "C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt";

            //    //File.Copy(origenArchivo, destinoArchivo, true); //Copiar
            //    //File.Move(origenArchivo, destinoArchivo); //mover

            //    //Eliminar
            //    //File.Delete("C:\\Users\\Isaac_Estrada\\Desktop\\testMoverFile.txt");


            //}
            //else
            //{
            //    Console.WriteLine("No se encontro el archivo");
            //}
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


            //Crear un directorio -> con una subcarpeta
            //Directory.CreateDirectory("MiSegundaCarpeta");
            //Directory.CreateDirectory("MiSegundaCarpeta\\MiTerceraCarpeta");

            //DirectoryInfo directoryInfo = Directory.CreateDirectory("MiCuartaCarpeta");

            //Console.WriteLine($"Nombre: {directoryInfo.Name}");
            //Console.WriteLine($"Ruta absoluta: {directoryInfo.FullName}");
            //Console.WriteLine($"Fecha de creacion: {directoryInfo.CreationTime}");

            //Console.ReadKey();

            #endregion


            #region "Uso  de @ para la secuencia de escape"
            //Directory.CreateDirectory(@"C:\Users\Isaac_Estrada\Desktop\TestingDelete");

            #endregion


            #region "Mover, eliminar, saber si existe un directorio"
            //string origen = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug\\MiSegundaCarpeta\\MiTerceraCarpeta";
            //string destino = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug\\MiTerceraCarpeta";

            //Mover
            //if (Directory.Exists(origen))
            //{
            //    Console.WriteLine("Existe el directorio");

            //    //Mover un directorio
            //    if (!Directory.Exists(destino))
            //    {
            //        Directory.Move(origen, destino);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El directorio destino ya exite");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Existe el directorio");
            //}


            //string directorio = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug\\MiTerceraCarpeta";


            ////Borrar
            //if (Directory.Exists(directorio))
            //{
            //    /*
            //     * 
            //     * True para eliminar carpeta mas contenido
            //     * 
            //     * False para eliminar solamente si esta vacia
            //     * 
            //     */

            //    Directory.Delete(directorio, true);
            //}
            //else
            //{
            //    Console.WriteLine("No Existe el directorio");
            //}
            #endregion


            #region "Nombre de todos los archivos"

            //Matriz para almacenar todos los archivos

            //string[] nombreArchivos;

            //nombreArchivos = Directory.GetFiles("C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug");

            //foreach (string item in nombreArchivos)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(Path.GetFileName(item));
            //}

            #endregion


            #region "Nombre de todos las carpetas"

            ////Matriz para almacenar todos los archivos

            //string[] nombreCarpetas;

            //nombreCarpetas = Directory.GetDirectories("C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug");

            //foreach (string item in nombreCarpetas)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(Path.GetFileName(item));
            //}

            #endregion


            #region "Nombre de todos las carpetas y archivos"

            //string ruta = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug";

            //string[] archivosDirectorios = Directory.GetFileSystemEntries(ruta);

            //foreach (string item in archivosDirectorios)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(Path.GetFileName(item));
            //}

            #endregion


            #region "Conocer la extension"

            //string ruta = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug\\Curso de C#.exe";

            //string extension = Path.GetExtension(ruta);

            //Console.WriteLine(extension);

            #endregion


            #region "Combinar la extension"

            string rutaBase = "C:\\Users\\isaac\\Source\\Repos\\estradaisaac168\\CursoCSharp\\Curso de C#\\bin\\Debug";

            string rutaCompleta;

            Console.WriteLine("Ingrese nombre de la carpeta");
            string nombreDirectorio = Console.ReadLine();

            rutaCompleta = Path.Combine(rutaBase, nombreDirectorio);

            Directory.CreateDirectory(rutaCompleta);

            Console.WriteLine($"Se creo el directorio en: {rutaCompleta}");

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

            fileStream.Read(bufferLeerArchivo, 0, bufferLeerArchivo.Length);

            string cadenaDecodificada = Encoding.UTF8.GetString(bufferLeerArchivo);

            Console.WriteLine($"Este es el texto dentro del archivo: {cadenaDecodificada}");

            fileStream.Close();
        }
    }
}
