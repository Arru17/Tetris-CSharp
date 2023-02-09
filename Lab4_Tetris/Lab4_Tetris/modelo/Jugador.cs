using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Tetris.modelo
{
    /*Clase que representa a un Jugador y todos sus atributos
  Atributos: nickname representa el alias del Jugador
             clave representa la contraseña del Jugador
			 masAltos representa los 3 puntajes mas altos del Jugador
			 cantPartidas representa la cantidad de partidas jugadas por el Jugador
			 numeroLineas representa la cantidad de lineas borradas por el Jugador
			 tetris representa la partida actual que pueda estar jugadno el Jugador*/
    public class Jugador
    {
        String nickname { get; set; }
        String clave { get; set; }
        int[] masAltos { get; set; }
        int cantPartidas { get; set; }
        int numeroLineas { get; set; }
        Tetris tetris { get; set; }
        /*Metodo getter y setter del atributo nickname*/
        public String Nick
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
        /*Metodo getter y setter del atributo clave*/
        public String Pass
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }
        /*Metodo getter y setter del atributo masAltos*/
        public int[] Puntaje
        {
            get
            {
                return masAltos;
            }
            set
            {
                masAltos = value;
            }
        }
        /*Metodo getter y setter del atributo cantPartidas*/
        public int Partidas
        {
            get
            {
                return cantPartidas;
            }
            set
            {
                cantPartidas = value;
            }
        }
        /*Metodo getter y setter del atributo numeroLineas*/
        public int Lineas
        {
            get
            {
                return numeroLineas;
            }
            set
            {
                numeroLineas = value;
            }
        }
        /*Metodo getter y setter del atributo tetris*/
        public Tetris Tetris
        {
            get
            {
                return tetris;
            }
            set
            {
                tetris = value;
            }
        }
        /*Constructor por defecto de la Clase Jugador*/
        public Jugador() { }
        /*Constructor que crea un objeto de la Clase Jugador con todos sus atributos.
         Entrada: nick: String que corresponde al nickname del jugador
                  clave: String que corresponde a la clave del jugador
         Salida: Un objeto de la Clase Jugador*/
        public Jugador(String nick, String clave)
        {
            nickname = nick;
            this.clave = clave;
            masAltos = new int[3];
            for (int i = 0; i < 3; i++)
            {
                masAltos[i] = 0;
            }
            numeroLineas = 0;
            cantPartidas = 0;
        }
        /*Metodo que inicializa una partida creando un nuevo objeto de la Clase Tetris que se asocia al Jugador
	  Entrada: N: entero que indica la cantidad de filas que tendra la partida de Tetris
	           M: entero que indica la cantidad de columnas que tendra la partida de Tetris 
	           gamePieces: entero que indica la cantidad de piezas preposicionadas que habran en el Tablero
	           seed: entero con el cual se da inicion al random que genera las piezas
       Salida: void
	  */
        public void iniciarPartida(int N, int M, int cantPiezas, int seed)
        {
            tetris = new Tetris(N, M, cantPiezas, seed);
        }
        /*Metodo que finaliza la partida y revisa si es que el puntaje obtenido durante la partida 
	    logra entrar entre los 3 mas altos puntajes del Jugador*/
        /*Entrada: void
         * Salida: void*/
        public void terminarPartida()
        {
            int puntaje = tetris.Puntaje;
            ordenarPuntajes(puntaje);
        }
        /*Metodo que ordena los puntajes del Jugador y revisa si es que el puntaje nuevo entra o no entre los 3 as altos
	      Entrada: nuevo: entero que representa un nuevo puntaje que podria ser uno de los 3 mas altos
          Salida: void*/
        public void ordenarPuntajes(int nuevo)
        {
            int[] ptjs = this.Puntaje;
            if (nuevo > ptjs[0])
            {
                int aux = ptjs[0];
                ptjs[0] = nuevo;
                int aux2 = ptjs[1];
                ptjs[1] = aux;
                ptjs[2] = aux2;
            }
            else if (nuevo > ptjs[1])
            {
                int aux = ptjs[1];
                ptjs[1] = nuevo;
                ptjs[2] = aux;
            }
            else if (nuevo > ptjs[2])
            {
                ptjs[2] = nuevo;
            }
            else
            {

            }
            Puntaje = ptjs;
        }



    }
}