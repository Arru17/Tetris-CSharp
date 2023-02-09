using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Tetris.modelo
{
   /* Clase que representa un Tablero de Tetris
Atributos: matriz: arreglo de arreglos de enteros que corresponden al Tablero sobre el cual se realizan las jugadas
           bloquesPresentes: Lista de Bloques que contiene a todos los bloques posicionados sobre el Tablero
           N entero que representa la cantidad de Filas del Tablero
           M entero que representa la cantidad de Columnas que posee el Tablero*/
    public class Tablero
    {
        public int[,] matriz;
        List<Bloque> bloquesPresentes { get; set; }
        private int _N { get; set; }
        private int _M { get; set; }
        /*Metodo getter y setter del atributo _N*/
        public int N
        {
            get
            {
                return _N;
            }
            set
            {
                _N = value;
            }
        }
        /*Metodod getter y setter del atributo bloquesPresentes*/
        public List<Bloque> BloquesPresentes
        {
            get
            {
                return bloquesPresentes;
            }
            set
            {
                bloquesPresentes = value;
            }
        }
        /*Metodo getter y setter del atributo _M*/
        public int M
        {
            get
            {
                return _M;
            }
            set
            {
                _M = value;
            }
        }
        /*Constructor por defecto de la Clase Tablero*/
        public Tablero() { }
        //FUNCIONALIDAD CREATEBOARD()
        /*Metodo que crea un objeto de la Clase Tablero que recibe 4 enteros y 
         * retorna un Tablero completo con todos sus datos
         Entradas: N: Entero que representa la cantidad de Filas que contendra el Tablero
                    M: Entero que representa la cantidad de Columnas que contendra el Tablero
                    gamePieces: Entero que representa la cantidad de piezas que poseera el Tablero
                    seed: Entero que se utiliza para posicionar y crear aleatoriamente 
                          las piezas que contendra inicialmente el Tablero
         Salida: Tablero*/
        public Tablero crearTablero(int N, int M, int gamePieces, int seed)
        {
            Tablero board = new Tablero();
            board.matriz = new int[N, M];
            board._N = N;
            board._M = M;
            int x;
            for (x = 0; x < N; x++)
            {
                int y;
                for (y = 0; y < M; y++)
                {
                    board.matriz[x, y] = 0;
                }
            }
            Pieza piece;
            seed = 6;
            List<Pieza> piezasColocar = new List<Pieza>(gamePieces);
            int rand;
            int i;
            for (i = 0; i < gamePieces; i++)
            {
                
                rand = new Random().Next(0, seed);
                piece = new Pieza(rand);
                piece.correrPieza(piece, 4, N, rand);
                piezasColocar.Add(piece);
            }
            while (piezasColocar.Count != 0)
            {
                int k;
                if (esValido(board, piezasColocar[0]))
                {
                    if (revisarPosiciones(board, piezasColocar[0]))
                    {
                        colocarPieza(board, piezasColocar[0]);
                        piezasColocar.RemoveAt(0);
                    }
                    else
                    {
                        piezasColocar[0].correrPieza(piezasColocar[0], 2, N, 0);
                    }
                }
                else
                {
                    Pieza aux = piezasColocar[0];
                    for (k = 0; k < 4; k++)
                    {
                        if (aux.bloques[k].X == 0)
                        {
                            Console.WriteLine("No se pudieron agregar las piezas debido a que no alcanzo el espacio disponible\n");
                            return null;
                        }
                        else if (aux.bloques[k].Y == M)
                        {
                            piezasColocar[0].correrPieza(piezasColocar[0], 0, N, 0);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            board.bloquesPresentes = new List<Bloque>();
            return board;
        }//FIN FUNCIONALIDAD CREATEBOARD()

        //PARTE DE LA FUNCIONALIDAD CHECKBOARD()
        /*Metodo que verifica que un Tablero sea valido.
         Entrada: board: Tablero que se quiere revisar.
         Salida: bool: true, si cumple; si no cumple, false*/
        public bool checkBoard(Tablero board)
        {
            int contFilas = 0;
            if ((board._M >= 10) && (board._N >= 5))
            {
                int x;
                for (x = 0; x < board._N; x++)
                {
                    int contColumnas = 0;
                    int y;
                    for (y = 0; y < board._M; y++)
                    {
                        if ((board.matriz[x, y] == 0) || (board.matriz[x, y] == 1))
                        {
                            contColumnas++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (contColumnas == board._M)
                    {
                        contFilas++;

                    }
                    else
                    {
                        return false;
                    }
                }
                if (contFilas == board._N)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }//FIN DE LA FUNCIONALIDAD


        /*Metodo que encuentra todos los bloques presentes en el Tablero y las guarda en el atributo bloquesPresentes.
         Entrada: board: Tablero sel cual se busca obtener las posiciones ocupadas.
         Salida: void*/
        public void obtenerBloques(Tablero board)
        {
            int x;
            for (x = 0; x < board._N; x++)
            {
                int y;
                for (y = 0; y < board._M; y++)
                {
                    if (board.matriz[x, y] == 1)
                    {
                        Bloque block = new Bloque();
                        block.modificarPosicion(x, y);
                        board.agregarExistente(block);
                    }
                    else
                    {

                    }
                }
            }
        }
        //PARTE DE LA FUNCIONALIDAD CHECKBOARD()
        /*Metodo que se encarga de obtener todas las filas completas presentes en el Tablero y las guarda en una lista.
         Entrada: board: Tablero del cual se busca encontrar lasfilas completas.
         Salida: Lista de enteros*/
        public List<int> lineasCompletas(Tablero board)
        {
            List<int> lista = new List<int>(board._N);
            int x;
            for (x = 0; x < board._N; x++)
            {
                int contCol = 0;
                int y;
                for (y = 0; y < board._M; y++)
                {
                    if (board.matriz[x, y] == 1)
                    {
                        contCol = contCol + 1;
                    }
                    else
                    {
                        y = board._M;
                    }
                }
                if (contCol == board._M)
                {
                    lista.Add(x);
                }
            }
            return lista;
        }
        //FUNCIONALIDAD BOARDTOSTRING()
        /*Metodo que a partir de un Tablero genera una representacion 
         * en forma de String para que pueda ser imprimido por pantalla
         Entrada: board: Tablero que se busca representar.
         Salida: String*/
        public String boardToString(Tablero board)
        {
            String salida = "";
            int x;
            for (x = 0; x < board.N; x++)
            {
                int y;
                for (y = 0; y < board._M; y++)
                {
                    if (board.matriz[x, y] != 1)
                    {
                        salida = salida + "|0|";
                    }
                    else
                    {
                        salida = salida + "|1|";
                    }
                }
                salida = salida + "\n";
            }
            return salida;
        }
        /*Metodo que revisa si la pieza puede ser colocada en el Tablero 
         * (revisando que las posiciones que debe ocupar la pieza estan libres o no)
         Entrada: board: Tablero 
                  piece: Pieza la cual se busca revisar si puede ser colocada en el tablero
         Salida: bool: true, si la pieza puede ser colocada; si no, false*/
        public bool revisarPosiciones(Tablero board, Pieza piece)
        {

            int i;
            for (i = 0; i < 4; i++)
            {
                int x = piece.bloques[i].X;
                int y = piece.bloques[i].Y;
                if (board.matriz[x, y] == 1)
                {
                    i = 10;
                }
                else
                {
                }
            }
            return i == 4;
        }
        /*Metodo que coloca una pieza en el Tablero
         Entrada: board: Tablero
                  piece: Pieza que se busca colocar.
         Salida: void*/
        public void colocarPieza(Tablero board, Pieza piece)
        {
            int i;
            for (i = 0; i < 4; i++)
            {
                int x = piece.bloques[i].X;
                int y = piece.bloques[i].Y;
                board.matriz[x, y] = 1;
            }
        }
        /*Metodo que revisa si la pieza esta dentro de los limites del Tablero para saber si se puede colocar o no
         Entradas: board: Tablero
                   piece: Pieza que se busca revisar
         Salida: bool: true, si la pieza esta dentro de los limites; si no, false*/
        public bool esValido(Tablero board, Pieza piece)
        {
            int i;
            for (i = 0; i < 4; i++)
            {
                if ((piece.bloques[i].X < board.N) && (piece.bloques[i].Y < board.M))
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        /*Metodo que coloca una Lista de Bloques, uno por uno dentro del Tablero
         Entrada: bloques: Lista de bloques que se buscan colocar
         Salida: void*/
        public void colocarBloques(List<Bloque> bloques)
        {
            while (bloques.Count != 0)
            {
                int x = bloques[0].X;
                int y = bloques[0].Y;
                matriz[x, y] = 1;
                bloques.RemoveAt(0);
            }
        }
        /*Metodo con el cual se hace caer a las piezas que estan por encima de las filas borradas 
         * para que asi queden un nivel mas abajo
         Entrada: bloques: Lista de Bloques
                  listaFilas: lista de enteros que contiene las filas completas que existen
         Salida: void*/
        public void bajarBloques(List<Bloque> bloques, List<int> listaFilas)
        {
            int largo = bloques.Count;
            while (listaFilas.Count != 0)
            {
                int i;
                for (i = 0; i < largo; i++)
                {
                    if (bloques[i].X < listaFilas[0])
                    {
                        int newX = bloques[i].X;
                        bloques[i].X = (newX + 1);
                    }
                }
                listaFilas.RemoveAt(0);
            }
        }
        /*Metodo que coloca una matriz llena de ceros en el atributo matriz del Tablero
         Entrada: void
         Salida: void*/
        public void setMatrizNula()
        {
            int i;
            for (i = 0; i < N; i++)
            {
                int j;
                for (j = 0; j < M; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }
        //PARTE DE LA FUNCIONALIDAD CHECKBOARD()
        /*Metodo que borra del tablero todas las filas completas de 1s
         Entrada: listaFilas: Lista de enteros que contiene todas las filas completas
                  M: cantidad de columnas del tablero
         Salida: void*/
        public void borrarFilas(List<int> listaFilas, int M)
        {
            int size = listaFilas.Count;
            int i;
            for (i = 0; i < size; i++)
            {
                int fila = listaFilas[i];
                int j;
                for (j = 0; j < M; j++)
                {
                    matriz[fila, j] = 0;
                }
            }
        }
        /*Metodo que asigna el valor de blocks en el atributo bloquesPresentes del Tablero
	      Entrada: blocks: representa el nuevo valor de bloquesPresentes del Tablero
          Salida: void*/
        public void setExistentes(List<Bloque> blocks)
        {
            bloquesPresentes = blocks;
        }
        /*Metodo que agrega un Bloque al atributo bloquesPresentes del Tablero
	      Entrada: block: representa el nuevo Bloque del atributo bloquesPresentes
          Salida: void*/
        public void agregarExistente(Bloque block)
        {
            bloquesPresentes.Add(block);
        }

    }
}
