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
    public partial class VistaPrincipal : Form
    {
        public Jugador jugador { get; set; }
        public VistaInicio vi;
        public VistaJuego vj;
        /*Metodo getter y setter del atributo jugador*/
        public Jugador J1
        {
            get
            {
                return jugador;
            }
            set
            {
                jugador = value;
            }
        }
        /*Constructor por defecto de la Clase VistaPrincipal*/
        public VistaPrincipal() { }
        /*Constructor de la Clase VistaPrincipal que genera una 
         * VistaPrincipal con todos sus atributos y componentes listos
         Entrada: player: objeto de la Clase Jugador
                  vista: objeto de la Clase VistaInicio
         Salida: Objeto de la Clase VistaPrincipal*/
        public VistaPrincipal(Jugador player, VistaInicio vista)
        {
            InitializeComponent();
            jugador = player;
            vi = vista;
            textUser.Text = " Jugador: " + jugador.Nick;
            textLineas.Text = "Lineas eliminadas: " + jugador.Lineas;
            textPartidas.Text = "Partidas jugadas: " + jugador.Partidas;
            textAlto.Text = jugador.Puntaje[0] + " puntos";
            textMedio.Text = jugador.Puntaje[1] + " puntos";
            textBajo.Text = jugador.Puntaje[2] + " puntos";
            FormClosing += VistaPrincipal_FormClosing;
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VistaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
        /*Metodo que responde al evento de la vista (hacer click en el boton salir)*/
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                vi.Dispose();
            }
            else
            {

            }
        }
        /*Metodo que responde al evento de la vista (hacer click en el boton jugar)*/
        private void Jugar_Click(object sender, EventArgs e)
        {
            String filas = textFilas.Text;
            String columna = textColum.Text;
            String pieces = textPiezas.Text;
            String semilla = textSeed.Text;
            int N, M, gamePieces, seed;
            if(!filas.Equals("") && !columna.Equals("") && !pieces.Equals("") && !semilla.Equals(""))
            {
                if (Int32.TryParse(filas, out N) && (Int32.TryParse(columna, out M)) && (Int32.TryParse(pieces, out gamePieces)) && (Int32.TryParse(semilla, out seed)) )
                 {
                    if((N >= 5) && (M >= 10))
                    {
                        jugador.iniciarPartida(N, M, gamePieces, seed);
                        vj = new VistaJuego(jugador, this, N, M);
                        this.Hide();
                        vj.Show();
                    }
                    else
                    {
                        MessageBox.Show("El tablero minimo permitido es de 5 filas X 10 columnas.", "ERROR");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese solo numeros en las casillas (recuerde que el tablero minimo permitido es de 5 filas X 10 columnas).", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.", "ERROR");
            }
        }
    }
}