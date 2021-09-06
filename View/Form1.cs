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
        Model.Jogadores jogada = new Model.Jogadores();

        public Form1()
        {
            InitializeComponent();
            EscreveMatrix();
        }

        public void EscreveMatrix()
        {
            // Matrix será a referencia usada para cada letra usada no tabuleiro


            // FUNÇÃO ESCREVEMATRIZ DEVE SER FEITA NO CONTROLLER E SER PUXADO PARA O VIEW (AVISO DO PROFESSOR)
            matrix1.Text = Model.Geradores.iniciaTabuleiro("A", "D");
            matrix2.Text = Model.Geradores.iniciaTabuleiro("E", "F");
            matrix3.Text = Model.Geradores.iniciaTabuleiro("B", "C");

            matrix4.Text = Model.Geradores.iniciaTabuleiro("G", "I", "U");
            matrix5.Text = Model.Geradores.iniciaTabuleiro("H", "J", "V");
            matrix6.Text = Model.Geradores.iniciaTabuleiro("K", "L");

            matrix7.Text = Model.Geradores.iniciaTabuleiro("M", "O", "Q");
            matrix8.Text = Model.Geradores.iniciaTabuleiro("N", "T", "P");
            matrix9.Text = Model.Geradores.iniciaTabuleiro("R", "S", "Z");
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            textBoxPalavra.Text = textBoxPalavra.Text.ToUpper();

                                 //---------------------------------------------------------------------------------------------------------------------------------
                                 //---------------------------------------------------------------------------------------------------------------------------------
                                 //
                                 // fazer uma verificação para descobrir se são apenas letras para dar continuidade,
                                 // ou possuem numeros e caracteres especiais dentro da palavra 
                                 //
                                 //---------------------------------------------------------------------------------------------------------------------------------
                                 //---------------------------------------------------------------------------------------------------------------------------------
           
            bool repetido = false;
            string[][] matriztabuleiro = new string[3][];

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
                // faz uma tentativa na procura por erros, e em seguida se o resultado for positivo, dá continuidade ao programa
                // em caso de erro ele apaga o q foi ecrito na caixa de texto e da um aviso de erro

                bool valido = true;
                Controller.Controladores.CalculaPontos(matriztabuleiro, textBoxPalavra.Text);
                
                if (Controller.Controladores.PalavraInvalida(valido) == true)
                {
                    ListaDePalavras.Add(textBoxPalavra.Text);

                    jogada.Rodada++;
                    jogada.Palavra = textBoxPalavra.Text;
                    jogada.Acertos = Controller.Controladores.CalculaPontos(matriztabuleiro, textBoxPalavra.Text).acertos;
                    jogada.Pontos = Controller.Controladores.CalculaPontos(matriztabuleiro, textBoxPalavra.Text).pontos;

                    dataGridView.Rows.Add(jogada.Rodada, jogada.Palavra, jogada.Acertos, jogada.Pontos);

                    textBoxPalavra.Clear();
                }
                else
                {
                    MessageBox.Show("Contém Letra Repetida ou Invalida, tente outra!");
                    textBoxPalavra.Clear();
                } 
            
            }
            else if (repetido == true)
            {
                MessageBox.Show("Palavra Repetida, tente outra!");
                textBoxPalavra.Clear();
            }
            
        }

        private void buttonResetar_Click(object sender, EventArgs e)
        {
            EscreveMatrix();
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
