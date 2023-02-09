using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Tetris.modelo
{
    //Clase que representa una partida de Tetris.
    //Atributos: board (Tablero de juego del tetris)
    //           puntaje (puntaje acumulado durante la partida de Tetris)
    public class Tetris
    {
        private Tablero board { get; set; }
        private int puntaje { get; set; }
        /*Metodo getter y setter del atributo board*/
        public Tablero Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
            }
        }
        /*Metodo getter y setter del atributo puntaje*/
        public int Puntaje
        {
            get
            {
                return puntaje;
            }
            set
            {
                puntaje = value;
            }
        }
        /*Constructor por defecto de la Clase Tetris*/
        public Tetris() { }
        /*Constructor de la Clase Tetris que crea un Tetris con todos sus atributos incluidos y listo para jugar
         Entrada: N: Entero que representa la cantidad de filas del Tablero
                  M: Entero que representa la cantidad de columnas del Tablero
                  gamePieces: Entero que indica la cantidad de piezas que tendra el Tablero.
                  seed: Entero que se utiliza para generar y colocar las piezas de forma aleatoria
         Salida: Un objeto de la Clase Tetris*/
        public Tetris(int N, int M, int gamePieces, int seed)
        {
            Tablero tab = new Tablero();
            board = tab.crearTablero(N, M, gamePieces, seed);
            puntaje = 0;
        }
        /*Metodo que aumenta el puntaje de la partida en la cantidad indicada en points
	       Entrada: points: indica la cantidad de puntos que se aumentara al puntaje*/
        public void aumentarPuntaje(int points)
        {
            int puntajeAnt = Puntaje;
            int newPuntaje = puntajeAnt + points;
            Puntaje = newPuntaje;
        }
        /*Metodo para realizar una jugada en el tablero
	   Entradas : board: tablero de juego
	              piece pieza a posicionar dentro del tablero
	              posHoriz entero que indica la posicion de la columna donde se colocara la pieza
	   Salida: 10, si la pieza fue colocada correctamente y 100 si es que la pieza no se puede colocar*/
        public int play(Tablero board, Pieza piece, int posHoriz)
        {
            piece.reiniciarPosicion();
            piece.correrPieza(piece, 4, board.N, posHoriz);
            piece.correrPieza(piece, 5, 0, posHoriz);

            int aux = 0;
            while ((aux != 10) && (aux != 100))
            {
                if (board.esValido(board, piece))
                {
                    if (board.revisarPosiciones(board, piece))
                    {
                        board.colocarPieza(board, piece);
                        aux = 10;
                    }
                    else
                    {
                        piece.correrPieza(piece, 0, 0, 0);
                    }
                }
                else
                {
                    aux = 100;
                }
            }
            return aux;
        }

    }
}