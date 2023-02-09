using Lab4_Tetris.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Tetris.vista
{
    public partial class VistaJuego : Form
    {
        Jugador jugador;
        VistaPrincipal vp;
        Button[,] tab;
        Button[,] panelPieza;
        Pieza piece;
        /*Constructor por defecto de la clase VistaJuego*/
        public VistaJuego() { }
        /*Constructor e la clase VistaJuego que genera un objeto con todos sus atributos 
         Entrada: j: jugador
                  vista: objeto de la clase VistaPrincipal
                  N: entero que indica la cantidad de Filas del Tablero
                  M: entero que indica la cantidad de columnas del Tablero
          Salida: objeto de la clase VistaJuego*/
        public VistaJuego(Jugador j, VistaPrincipal vista, int N, int M)
        {
            jugador = j;
            vp = vista;
            InitializeComponent();
            tab = new Button[N,M];
            textPoints.Text = "0 puntos.";
            tableLayoutPanelTab.RowCount = N;
            tableLayoutPanelTab.ColumnCount = M;
            tableLayoutPanelTab.Width = 40 * M;
            tableLayoutPanelTab.Height = 40 * N;
           
            for (int i=0; i<N;i++)
            {
                for (int k=0;k<M;k++)
                {
                    tab[i, k] = new Button();
                    tab[i, k].Height = 40;
                    tab[i, k].Width = 40;
                    tab[i, k].Margin = new Padding(0, 0, 0, 0);
                   if (jugador.Tetris.Board.matriz[i, k] == 1)
                    {
                        tab[i, k].Image = Properties.Resources.Charizard;
                        
                    }
                    else
                    {
                        tab[i, k].Image = Properties.Resources.Samurott;
                        
                    }
                    tableLayoutPanelTab.Controls.Add(tab[i, k], k, i);
                }
            }
            //FUNCIONALIDAD NEXTPIECE()
            int rand = new Random().Next(0, 7);
            piece = new Pieza(rand);
            piece.correrPieza(piece,4,4,0);
            panelPieza = new Button[4,4];
            mostrarPieza(piece,panelPieza,1);
            //FIN FUNCIONALIDAD NEXTPIECE()
            FormClosing += VistaJuego_FormClosing;

        }
        /*Metodo que muestra la siguiente pieza a traves de un tableLayoutPanel 
         Entrada: piece: Pieza a mostrar
                  panelPieza: arreglo de botones que seran colocados en el tableLayoutPanel
                  ind: entero que indica si es primera vez que se utiliza el metodo durante la ejecucion o no
         Salida: void*/
        private void mostrarPieza(Pieza piece, Button[,] panelPieza, int ind)
        {
            if (ind == 1)
            {

                for (int r = 0; r < 4; r++)
                {
                    for (int s = 0; s < 4; s++)
                    {
                        panelPieza[r, s] = new Button();
                        panelPieza[r, s].Height = 40;
                        panelPieza[r, s].Width = 40;
                        panelPieza[r, s].Margin = new Padding(0, 0, 0, 0);
                    }
                }
            }
            int x1, x2, x3, x4, y1, y2, y3, y4;
            x1 = piece.bloques[0].X; y1 = piece.bloques[0].Y;
            x2 = piece.bloques[1].X; y2 = piece.bloques[1].Y;
            x3 = piece.bloques[2].X; y3 = piece.bloques[2].Y;
            x4 = piece.bloques[3].X; y4 = piece.bloques[3].Y;
            for (int p = 0; p < 4; p++)
            {
                for (int f = 0; f < 4; f++)
                {
                     if (((x1 == p) && (y1 == f)) || ((x2 == p) && (y2 == f)) || ((x3 == p) && (y3 == f)) || ((x4 == p) && (y4 == f)))
                     {
                        panelPieza[p, f].Image = Properties.Resources.Charmander;
                     }
                     else
                     {
                        panelPieza[p, f].Image = Properties.Resources.Oshawott;
                     }
                    if (ind == 1)
                    {
                        tableLayoutPanelPieza.Controls.Add(panelPieza[p, f], f, p);
                    }
                    }
                }
            
        }

        private void VistaJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void VistaJuego_Load(object sender, EventArgs e)
        {

        }
        /*Metodo que responde al evento de la vista (hacer click en el boton rotar)*/
        private void Rotar_Click(object sender, EventArgs e)
        {
            piece.rotarPieza();
            piece.correrPieza(piece, 4, 4, 0);
            mostrarPieza(piece, panelPieza,0);
        }
        //FUNCIONALIDAD PLAY()
        /*Metodo que responde al evento de la vista (hacer click en el boton colocar)*/
        private void Colocar_Click(object sender, EventArgs e)
        {
            String pos = textPosHoriz.Text;
            int posHoriz;
            Int32.TryParse(pos, out posHoriz);
            if (posHoriz < jugador.Tetris.Board.M)
            {
                try
                {
                    int resultado = jugador.Tetris.play(jugador.Tetris.Board, piece, posHoriz);
                    textPosHoriz.Text = "";
                    if (resultado == 10)
                    {
                        //Console.WriteLine("Pieza colocada exitosamente.");
                        int puntajeColoc = 150;
                        int puntajeActual = jugador.Tetris.Puntaje;
                        List<int> listaFilas = jugador.Tetris.Board.lineasCompletas(jugador.Tetris.Board);
                        if (listaFilas == null)
                        {
                            jugador.Tetris.Puntaje = (puntajeColoc + puntajeActual);
                            textPoints.Text = (puntajeColoc + puntajeActual) + " puntos.";
                        }
                        else
                        {
                            int cantFilas = listaFilas.Count;
                            int filasBorradas = jugador.Lineas;
                            jugador.Lineas = (filasBorradas + cantFilas);
                            jugador.Tetris.Board.borrarFilas(listaFilas, jugador.Tetris.Board.M);
                            jugador.Tetris.Board.obtenerBloques(jugador.Tetris.Board);
                            jugador.Tetris.Board.bajarBloques(jugador.Tetris.Board.BloquesPresentes, listaFilas);
                            jugador.Tetris.Board.colocarBloques(jugador.Tetris.Board.BloquesPresentes);
                            jugador.Tetris.Puntaje = (puntajeColoc + puntajeActual + (750 * cantFilas));
                            textPoints.Text = (puntajeColoc + puntajeActual + (750 * cantFilas)) + " puntos.";
                        }
                        //FUNCIONALIDAD NEXTPIECE()
                        int rando = new Random().Next(0, 7);
                        piece = new Pieza(rando);
                        actualizarTablero();
                        piece.correrPieza(piece, 4, 4, 0);
                        mostrarPieza(piece, panelPieza, 0);
                        //FIN FUNCIONALIDAD NEXTPIECE()
                    }
                    else if (resultado == 100)
                    {
                        //Console.WriteLine("Has perdido...");
                        MessageBox.Show("Has perdido....", "Lo sentimos");
                        int cantPart = jugador.Partidas;
                        jugador.Partidas = (cantPart + 1);
                        jugador.terminarPartida();
                        this.Hide();
                        vp = new VistaPrincipal(jugador, vp.vi);
                        vp.Show();
                    }
                    else
                    {
                    }
                }
                catch (IndexOutOfRangeException a)  
                {
                    Console.WriteLine(a.Message);
                    MessageBox.Show("Has perdido....", "Lo sentimos");
                    int cantPart = jugador.Partidas;
                    jugador.Partidas = (cantPart + 1);
                    jugador.terminarPartida();
                    this.Hide();
                    vp = new VistaPrincipal(jugador, vp.vi);
                    vp.Show();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor menor a la cantidad de columnas.", "ERROR");
            }
            
            
        }//FIN FUNCIONALIDAD PLAY

        /*Metodo que responde al evento de la vista (hacer click en el boton salir)*/
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int cantPart = jugador.Partidas;
                jugador.Partidas = (cantPart + 1);
                jugador.terminarPartida();
                //vp.J1 = jugador;
                this.Hide();
                vp = new VistaPrincipal(jugador,vp.vi);
                vp.Show();
            }
            else
            {

            }
        }
        /*Metodo que se utiliza para actualizar el tablero en la vista*/
        public void actualizarTablero()
        {
            int n = jugador.Tetris.Board.N;
            int m = jugador.Tetris.Board.M;
            for (int i=0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (jugador.Tetris.Board.matriz[i, j] == 1)
                    {
                        tab[i, j].Image = Properties.Resources.Charizard;

                    }
                    else
                    {
                        tab[i, j].Image = Properties.Resources.Samurott;

                    }
                }
            }
                
        }
        /*Metodo que responde al evento de la vista (hacer click en el boton imprimir tablero)*/
        private void ImprimirTab_Click(object sender, EventArgs e)
        {
            Console.WriteLine(jugador.Tetris.Board.boardToString(jugador.Tetris.Board));
        }
    }
}
