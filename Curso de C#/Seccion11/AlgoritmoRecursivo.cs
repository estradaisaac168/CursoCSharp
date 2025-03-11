using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.Seccion11
{
    class AlgoritmoRecursivo
    {
        /*
         * 
         * RECURSIVIDAD
         * 
         * Crear instrucciones que se repiten varias veces hasta conseguir un resultado
         * 
         * Por ejemplo llamar al metodo dentro del mismo metodo()
         * 
         */


        public void Init() {

            string origenDirectorio = "C:\\Users\\Isaac_Estrada\\source\\repos\\Curso de C#\\Curso de C#\\bin";
            string destinoDirectorio = "C:\\Users\\Isaac_Estrada\\Desktop\\bin";

            CopiarDirectorio(origenDirectorio, destinoDirectorio);
        }

        static private void CopiarDirectorio(string origenDirectorio, string destinoDirectorio)
        {
            //Verificar si existe el directorio
            if (!Directory.Exists(destinoDirectorio))
            {
                //Crear el directorio
                Directory.CreateDirectory(destinoDirectorio);
            }

            //Matriz para guardar las rutas completas de los archivos
            string[] archivos = Directory.GetFiles(origenDirectorio);

            foreach (var archivoRutaOrigen in archivos)
            {
                string nombreArchivo = Path.GetFileName(archivoRutaOrigen);

                string rutaCompletaArchivoDestino = Path.Combine(destinoDirectorio, nombreArchivo);

                File.Copy(archivoRutaOrigen, rutaCompletaArchivoDestino);
            }

            //Matriz para almacenar los nombres de los directorios
            string[] subdirectorios = Directory.GetDirectories(origenDirectorio);

            foreach (var subdirectorioRutaOrigen in subdirectorios)
            {
                string nombreSubdirectorio = Path.GetFileName(subdirectorioRutaOrigen);

                string rutaCompletaSubdirectorioDestino = Path.Combine(destinoDirectorio, nombreSubdirectorio);

                CopiarDirectorio(subdirectorioRutaOrigen, rutaCompletaSubdirectorioDestino);
            }

        }
    }
}
