using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoMVC_02.Controller;

namespace TrabalhoMVC_02
{
    public partial class Form1 : Form
    {
        List<string> ListaDePalavras = new List<string>();
        Model.Jogadores jogada = new Model.Jogadores();

        public Form1()
        {
            InitializeComponent();

            matrix1.Text = Controladores.EscreveMatrix().matrix1;
            matrix2.Text = Controladores.EscreveMatrix().matrix2;
            matrix3.Text = Controladores.EscreveMatrix().matrix3;
            matrix4.Text = Controladores.EscreveMatrix().matrix4;
            matrix5.Text = Controladores.EscreveMatrix().matrix5;
            matrix6.Text = Controladores.EscreveMatrix().matrix6;
            matrix7.Text = Controladores.EscreveMatrix().matrix7;
            matrix8.Text = Controladores.EscreveMatrix().matrix8;
            matrix9.Text = Controladores.EscreveMatrix().matrix9;


            // Matrix será a referencia usada para cada botão de letra usado no tabuleiro
        }

        

        private void textBoxPalavra_KeyPress(object sender, KeyPressEventArgs e)
        {

         // utilizado para facilitar a experiência de usuário, quando apertar enter após escrever a palavra, ele clica sozinho no botão
         
            if (e.KeyChar == (char)13)
            {
                 buttonIniciar.PerformClick();                
            }
        }

        private  void buttonIniciar_Click(object sender, EventArgs e)
        {
            textBoxPalavra.Text = textBoxPalavra.Text.ToUpper();

            bool palavra = Controladores.VerificaPalavra(textBoxPalavra.Text);

            if (palavra == true)
            {
                bool repetido = false;
                string[][] matriztabuleiro = new string[3][];

                // cria uma matriz baseada nos boões e nas letras correspondentes para possibilitar um mapeamento mais funcional

                for (int i = 0; i < matriztabuleiro.Length; i++)
                {
                    matriztabuleiro[i] = new string[3];
                }

                matriztabuleiro[0][0] = matrix1.Text;
                matriztabuleiro[0][1] = matrix2.Text;
                matriztabuleiro[0][2] = matrix3.Text;

                matriztabuleiro[1][0] = matrix4.Text;
                matriztabuleiro[1][1] = matrix5.Text;
                matriztabuleiro[1][2] = matrix6.Text;

                matriztabuleiro[2][0] = matrix7.Text;
                matriztabuleiro[2][1] = matrix8.Text;
                matriztabuleiro[2][2] = matrix9.Text;



                foreach (var item in ListaDePalavras)
                {
                    if (item == textBoxPalavra.Text)
                    {
                        repetido = true;
                    }
                }

                if (repetido == false)
                {
                    ListaDePalavras.Add(textBoxPalavra.Text);

                    jogada.Rodada++;
                    jogada.Palavra = textBoxPalavra.Text;
                    jogada.Acertos = Controller.Controladores.CalculaPontos(matriztabuleiro, textBoxPalavra.Text).acertos;
                    jogada.Pontos = Controller.Controladores.CalculaPontos(matriztabuleiro, textBoxPalavra.Text).pontos;

                    dataGridView.Rows.Add(jogada.Rodada, jogada.Palavra, jogada.Acertos, jogada.Pontos);

                    textBoxPalavra.Clear();

                }
                else if (repetido == true)
                {
                    MessageBox.Show("Palavra Repetida, tente outra vez!");
                    textBoxPalavra.Clear();
                }
            }
            else 
            {
                MessageBox.Show("Palavra Invalida, tente outra vez!");
                textBoxPalavra.Clear();
            }
            
        }

        private void buttonResetar_Click(object sender, EventArgs e)
        {
            matrix1.Text = Controladores.EscreveMatrix().matrix1;
            matrix2.Text = Controladores.EscreveMatrix().matrix2;
            matrix3.Text = Controladores.EscreveMatrix().matrix3;
            matrix4.Text = Controladores.EscreveMatrix().matrix4;
            matrix5.Text = Controladores.EscreveMatrix().matrix5;
            matrix6.Text = Controladores.EscreveMatrix().matrix6;
            matrix7.Text = Controladores.EscreveMatrix().matrix7;
            matrix8.Text = Controladores.EscreveMatrix().matrix8;
            matrix9.Text = Controladores.EscreveMatrix().matrix9;

            textBoxPalavra.Clear();
            dataGridView.Rows.Clear();
            ListaDePalavras.Clear();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
