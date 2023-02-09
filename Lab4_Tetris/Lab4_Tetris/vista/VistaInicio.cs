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
    public partial class VistaInicio : Form
    {
        /*Constructor por defecto de la Clase VistaInicio*/
        public VistaInicio()
        {
            InitializeComponent();
            FormClosing += VistaInicio_FormClosing;
        }

        
        private void VistaInicio_Load(object sender, EventArgs e)
        {

        }

        private void VistaInicio_FormClosing(object sender, FormClosingEventArgs e)
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
        /*Metodo que responde al evento de la vista (hacer click en el boton ingresar)*/
        private void Ingresar_Click(object sender, EventArgs e)
        {
            String nick = textBoxNick.Text;
            String pass1 = textBoxPass1.Text;
            String pass2 = textBoxPass2.Text;
            if (!nick.Equals("") && !pass1.Equals("") && !pass2.Equals(""))
            {
                if (pass1.Equals(pass2))
                {
                    Jugador j = new Jugador(nick, pass1);
                    VistaPrincipal vp = new VistaPrincipal(j, this);
                    this.Hide();
                    vp.Show();

                }
                else
                {
                    textBoxPass1.Text = "";
                    textBoxPass2.Text = "";
                    MessageBox.Show("Las passwords no coinciden.", "ERROR");
                }

            }
            else
            {
                textBoxPass1.Text = "";
                textBoxPass2.Text = "";
                MessageBox.Show("No dejes ningun campo sin llenar.", "ERROR");
            }
            
        }
    }
}
