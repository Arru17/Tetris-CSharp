using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Tetris.modelo
{
    /**Clase que representa una pieza compuesta por 4 Bloques
Atributos: tipo: entero que representa el tipo de la Pieza (si es una pieza O, T o Z por ejemplo)
           rotaciones: entero que representa la cantidad de rotaciones realizadas a la Pieza
		   bloques: arreglo de 4 Bloques que corresponden a las 4 posiciones que ocupa la pieza dentro del Tablero**/
    public class Pieza
    {
        private int tipo { get; set; }
        private int rotaciones { get; set; }
        public Bloque[] bloques;
        /*Metodo getter y setter del atributo tipo*/
        public int Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        /*Metodo getter y setter del atributo rotaciones*/
        public int Rotaciones
        {
            get
            {
                return rotaciones;
            }
            set
            {
                rotaciones = value;
            }
        }
        /*Constructor de la Clase Pieza, crea una Pieza a partir de un entero
         Atributo: indice: entero que indica de que tipo sera la Pieza.
         Salida: Un objeto de la clase Pieza con todos sus atributos*/
        public Pieza(int indice)
        {
            bloques = new Bloque[4];
            int result = indice % 7;
            switch (result)
            {
                case 0:
                    bloques[0] = new Bloque(0, 0);
                    bloques[1] = new Bloque(0, 1);
                    bloques[2] = new Bloque(1, 0);
                    bloques[3] = new Bloque(1, 1);
                    Tipo = 0;
                    Rotaciones = 0;
                    break;
                case 1:
                    bloques[0] = new Bloque(0, 0);
                    bloques[1] = new Bloque(1, 0);
                    bloques[2] = new Bloque(2, 0);
                    bloques[3] = new Bloque(3, 0);
                    Tipo = 1;
                    Rotaciones = 0;
                    break;
                case 2:
                    bloques[0] = new Bloque(0, 0);
                    bloques[1] = new Bloque(0, 1);
                    bloques[2] = new Bloque(1, 1);
                    bloques[3] = new Bloque(1, 2);
                    Tipo = 2;
                    Rotaciones = 0;
                    break;
                case 3:
                    bloques[0] = new Bloque(0, 1);
                    bloques[1] = new Bloque(0, 2);
                    bloques[2] = new Bloque(1, 0);
                    bloques[3] = new Bloque(1, 1);
                    Tipo = 3;
                    Rotaciones = 0;
                    break;
                case 4:
                    bloques[0] = new Bloque(0, 0);
                    bloques[1] = new Bloque(0, 1);
                    bloques[2] = new Bloque(1, 0);
                    bloques[3] = new Bloque(2, 0);
                    Tipo = 4;
                    Rotaciones = 0;
                    break;
                case 5:
                    bloques[0] = new Bloque(0, 0);
                    bloques[1] = new Bloque(0, 1);
                    bloques[2] = new Bloque(1, 1);
                    bloques[3] = new Bloque(2, 1);
                    Tipo = 5;
                    Rotaciones = 0;
                    break;
                case 6:
                    bloques[0] = new Bloque(0, 1);
                    bloques[1] = new Bloque(1, 0);
                    bloques[2] = new Bloque(1, 1);
                    bloques[3] = new Bloque(1, 2);
                    Tipo = 6;
                    Rotaciones = 0;
                    break;
            }
        }
        /**Metodo que rota una pieza (hacia la derecha) cambiando la posicion que ocupan 
         * sus bloques dentro del Tablero
         * Entrada: void
	    Salida: void**/
        public void rotarPieza()
        {
            int type = Tipo;
            int rotacion;
            switch (type)
            {
                case 0:
                    rotacion = Rotaciones;
                    bloques[0].modificarPosicion(0, 0);
                    bloques[1].modificarPosicion(0, 1);
                    bloques[2].modificarPosicion(1, 0);
                    bloques[3].modificarPosicion(1, 1);
                    break;
                case 1:
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(0, 3);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(3, 0);
                            Rotaciones = 0;
                            break;
                    }
                    break;
                case 2: //Pieza S
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 0);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            Rotaciones = 0;
                            break;
                    }
                    break;
                case 3: //Pieza Z.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(0, 2);
                            bloques[2].modificarPosicion(1, 0);
                            bloques[3].modificarPosicion(1, 1);
                            Rotaciones = 0;
                            break;
                    }
                    break;
                case 4: //Pieza L.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 1);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(2, 1);
                            Rotaciones = 2;
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 2);
                            Rotaciones = 3;
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 0);
                            bloques[3].modificarPosicion(2, 0);
                            Rotaciones = 0;
                            break;
                    }
                    break;
                case 5: //Pieza J.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 0);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(2, 1);
                            Rotaciones = 2;
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 2);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            Rotaciones = 3;
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            Rotaciones = 0;
                            break;
                    }
                    break;
                case 6: //Pieza T.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            Rotaciones = 1;
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 1);
                            Rotaciones = 2;
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 0);
                            Rotaciones = 3;
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            Rotaciones = 0;
                            break;
                    }break;
                    
            }
        }

        /*Metodo que desplaza una pieza hacia arriba, abajo, derecha o izquierda o la acomoda para 
         * poder ser colocada en el Tablero
         Entradas: piece: Pieza sobre la que se realiza la accion
                    direccion: Entero que define que tipo de accion se realiza sobre la pieza.
                    N: Entero que representa la cantidad de filas del tablero.
                    columna: Entero que representa la columna sobre la cual hay que acomodar la pieza.
          Salida: void*/
        public void correrPieza(Pieza piece, int direccion, int N, int columna)
        {
            int xd;
            switch (direccion)
            {
                case 0: //Subir

                    for (xd = 0; xd < 4; xd++)
                    {
                        int newX = piece.bloques[xd].X - 1;
                        piece.bloques[xd].X = newX;
                    }
                    break;
                case 1: //Bajar
                    for (xd = 0; xd < 4; xd++)
                    {
                        int newX = piece.bloques[xd].X + 1;
                        piece.bloques[xd].X = newX;
                    }
                    break;
                case 2: //Derecha
                    for (xd = 0; xd < 4; xd++)
                    {
                        int newY = piece.bloques[xd].Y + 1;
                        piece.bloques[xd].Y = newY;
                    }
                    break;
                case 3: //Izquierda
                    for (xd = 0; xd < 4; xd++)
                    {
                        int newY = piece.bloques[xd].Y - 1;
                        piece.bloques[xd].Y = newY;
                    }
                    break;
                case 4: //Filas
                    for (xd = 0; xd < 4; xd++)
                    {
                        int newX;
                        newX = N - 1 - piece.bloques[xd].X;
                        piece.bloques[xd].X = newX;
                    }
                    break;
                case 5:  //Columnas
                    for (xd = 0; xd < 4; xd++)
                    {
                        int newY = columna + piece.bloques[xd].Y;
                        piece.bloques[xd].Y = newY;
                    }
                    break;
            }
        }

        /*Metodo que reinicia la posicion de la pieza a una posicion neutra 
         * (quita de la pieza toda accion que se pueda haber llevado a cabo sobre ella)
         Entrada: void
         Salida: void*/
        public void reiniciarPosicion()
        {
            int type = Tipo;
            int rotacion;
            switch (type)
            {
                case 0:
                    rotacion = Rotaciones;
                    bloques[0].modificarPosicion(0, 0);
                    bloques[1].modificarPosicion(0, 1);
                    bloques[2].modificarPosicion(1, 0);
                    bloques[3].modificarPosicion(1, 1);
                    break;
                case 1: //Pieza I
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(3, 0);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(0, 3);
                            break;
                    }
                    break;
                case 2: //Pieza S
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 0);
                            break;
                    }
                    break;
                case 3: //Pieza Z.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(0, 2);
                            bloques[2].modificarPosicion(1, 0);
                            bloques[3].modificarPosicion(1, 1);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            break;
                    }
                    break;
                case 4: //Pieza L.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 0);
                            bloques[3].modificarPosicion(2, 0);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 1);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(2, 1);
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 2);
                            break;
                    }
                    break;
                case 5: //Pieza J.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 0);
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(2, 0);
                            bloques[3].modificarPosicion(2, 1);
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 2);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            break;
                    }
                    break;
                case 6: //Pieza T.
                    rotacion = Rotaciones;
                    switch (rotacion)
                    {
                        case 0:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(1, 2);
                            break;
                        case 1:
                            bloques[0].modificarPosicion(0, 1);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 1);
                            break;
                        case 2:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(0, 1);
                            bloques[2].modificarPosicion(0, 2);
                            bloques[3].modificarPosicion(1, 1);
                            break;
                        case 3:
                            bloques[0].modificarPosicion(0, 0);
                            bloques[1].modificarPosicion(1, 0);
                            bloques[2].modificarPosicion(1, 1);
                            bloques[3].modificarPosicion(2, 0);
                            break;
                    }
                    break;

            }
        }
/*
        public void imprimirPieza()
        {
            for(int x = 0; x < 4; x++)
            {
                Console.WriteLine(bloques[x].X +","+bloques[x].Y);
            }
        }*/

    }
}
