using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_C_.ProyectoFinal
{
    class IntroduccionJuego
    {
        //Creamos un arreglo bidimensional para el tablero del juego
        static int[,] tablero = new int[3, 3]; //3 filas y 3 columnas.

        static char[] simbolo = { ' ', 'O', 'X' }; //Lo que se dibujara en el tablero


        public void ComenzarJuego()
        {
            bool terminar = false;

            //Dibujar el tablero inicial
            DibujarTablero();

            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");

            do
            {
                //Turno al jugador uno
                PreguntarPosicion(1);

                //Dibujar casilla en tablero
                DibujarTablero();

                //Comprobar si ha ganado la partida el jugador 1
                terminar = ComprobarGanador();

                if (terminar)
                {
                    Console.WriteLine("El jugador 1 ha ganado");
                }
                else
                {
                    //Comprobar si hay enpate
                    terminar = ComprobarEmpate();

                    if (terminar)
                    {
                        Console.WriteLine("Hay un empate");
                    }
                    else
                    {
                        //Turno del jugador dos
                        PreguntarPosicion(2);

                        //Dibujar casilla tablero
                        DibujarTablero();

                        terminar = ComprobarGanador();

                        if (terminar)
                        {
                            Console.WriteLine("El jugador 2 ha ganado");
                        }
                    }  
                }

            } while (terminar == false);
        }


        //Dibujar el tablero
        static void DibujarTablero()
        {
            //Conteo del ciclo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); //Es un espacio antes de dibujar el tablero
            Console.WriteLine("-------------"); //Dibuja la primera linea vertical del tablero

            for (fila = 0; fila < 3; fila++)
            {
                Console.Write("|"); //La segunda linea en horizontal
                for (columna = 0; columna < 3; columna++)
                {
                    //Dibujar un espacio, un cero o una x
                    Console.Write($" {simbolo[tablero[fila, columna]]} |");
                }

                Console.WriteLine();
                Console.WriteLine("-------------"); //Dibuja las lineas horizontales
            }

            Console.WriteLine();
        }

        //Donde escribir y dibujar en el tablero
        static void PreguntarPosicion(int jugador)
        {
            int fila;
            int columna;

            do
            {

                Console.WriteLine();
                Console.WriteLine($"Turno del jugador: {jugador}");

                //Pedir el numero de fila
                do
                {
                    Console.WriteLine("Selecciona la fila (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());
                }
                while ((fila < 1) || (fila > 3)); //Mientras fila menor 1 y fila mayor a 3 

                //Pedir el numero de columna
                do
                {
                    Console.WriteLine("Selecciona la columna (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());
                }
                while ((columna < 1) || (columna > 3));

                if (tablero[fila -1, columna -1] != 0) //Comienzan desde cero por eso se le resta un 1
                {
                    Console.WriteLine("Casilla ocupada");
                }
            }
            while (tablero[fila - 1, columna - 1] != 0);

            //Si todo es correcto asignar al jugador correspondiente
            tablero[fila - 1, columna - 1] = jugador;
        }

        //Devuelve true si hay tres en linea
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;

            bool ticTacToc = false;

            //Si en alguna fila todas son iguales
            for (fila = 0; fila < 3; fila++)
            {
                if ((tablero[fila, 0] == tablero[fila, 1]) 
                    && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] != 0)) 
                {
                    ticTacToc = true;
                }
            }


            for (columna = 0; columna < 3; columna++)
            {
                if (    (tablero[0, columna] == tablero[1, columna])
                    &&  (tablero[0, columna] == tablero[2, columna])
                    &&  (tablero[0, columna] != 0))
                {
                    ticTacToc = true;
                }
            }

            if (    (tablero[0, 0] == tablero[1, 1])
                 && (tablero[0, 0] == tablero[2, 2])
                 && (tablero[0, 0] != 0))
            {
                ticTacToc = true;
            }


            if (    (tablero[0, 2] == tablero[1, 1])
                 && (tablero[0, 2] == tablero[2, 0])
                 && (tablero[0, 2] != 0))
            {
                ticTacToc = true;
            }
        
            return ticTacToc;
        }

        //Devuelve true si hay empate
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;

            int fila = 0;
            int columna = 0;

            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    if (tablero[fila, columna] == 0)
                    {
                        hayEspacio = true;
                    }
                }
            }

            return !hayEspacio;
        }
    }
}
