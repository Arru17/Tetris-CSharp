using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Tetris.modelo
{
    /**Clase que representa la posicion que ocupa un Bloque dentro del Tablero
   Atributos: x: entero que corresponde a la posicion en filas del Bloque
              y: entero que corresponde a la posicion en columnas del Bloque**/
    public class Bloque
    {
        private int x { get; set; }
        private int y { get; set; }
        /*Metodo getter y setter del atributo x*/
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;

            }
        }
        /*Metodo getter y setter del atributo y*/
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;

            }
        }
        /*Constructor por defecto de la clase Bloque*/
        public Bloque() { }
        /*Constructor que recibe 2 enteros y los setea como atributos
         Entradas:  x: Valor entero que representa la posicion X
                     y: Valor entero que representa la posicion Y
         Salida: Un objeto de la clase Bloque con los valores x e y asignados*/
        public Bloque(int x, int y)
        {
            X= x;
            Y= y;
        }
        /*Metodo que modifica ambos atributos del objeto Bloque
         Entradas: x: Valor entero que representara la nueva posicion X del Bloque
                    y: Valor entero que representara la nueva posicion Y del Bloque
         Salida: void*/
        public void modificarPosicion(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
