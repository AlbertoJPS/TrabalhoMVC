using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMVC_02
{
    public partial class Form1 : Form
    {
        List<string> ListaDePalavras = new List<string>();
        Model.Jogador jogador = new Model.Jogador();

        public Form1()
        {
            InitializeComponent();
            EscreveMatrix();
        }
        public void EscreveMatrix()
        {
            matrix1.Text = Model.Gerador.iniciaTabuleiro("A", "D");
            matrix2.Text = Model.Gerador.iniciaTabuleiro("E", "F");
            matrix3.Text = Model.Gerador.iniciaTabuleiro("B", "C");

            matrix4.Text = Model.Gerador.iniciaTabuleiro("G", "I", "U");
            matrix5.Text = Model.Gerador.iniciaTabuleiro("H", "J", "V");
            matrix6.Text = Model.Gerador.iniciaTabuleiro("K", "L");

            matrix7.Text = Model.Gerador.iniciaTabuleiro("M", "O", "Q");
            matrix8.Text = Model.Gerador.iniciaTabuleiro("N", "T", "P");
            matrix9.Text = Model.Gerador.iniciaTabuleiro("R", "S", "Z");
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            textBoxPalavra.Text = textBoxPalavra.Text.ToUpper();
        }

        private void buttonResetar_Click(object sender, EventArgs e)
        {
            EscreveMatrix();
            textBoxPalavra.Clear();
            //dgPontos.Rows.Clear();
            //lblPontos.Text = "";
            ListaDePalavras.Clear();
            
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
