using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMVC_02.Controller
{
    class Controladores
    {
        public static string finalizar = "";
        public static bool PalavraInvalida(bool valido)
        {
            if (finalizar == "erro")
            { return false; }
            else
            { return true; }
        }

        public static (int pontos, int acertos) CalculaPontos(string[][] matriz, string palavra)
        {
            // acionado Tupla para poder retornar ambos os valores, pontos e acertos ao mesmo tempo)

            finalizar = "";
            int acertos = 0;
            int acertosTemp = 0;
            int pontos = 0;
            string[] posAnteriores = new string[5];
            string[] vetorPalavra = new string[palavra.Length];
            

            for (int a = 0; a < palavra.Length; a++)
            {
                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        // verifica dentro da tabela se existe ou não a primeira letra, se se sim, já a pontua

                        vetorPalavra[a] = palavra[a].ToString();
                        finalizar = "";

                        if (matriz[i][j] == vetorPalavra[0] && a == 0)
                        {
                            posAnteriores[0] = matriz[i][j];
                            acertos += 1;
                            acertosTemp += 1;

                            if (acertosTemp == 2)
                            {
                                pontos += 1;
                                acertosTemp = 0;
                            }
                            finalizar = "fim";
                            break;
                        }

                        // verifica e atribui pontos as posições seguintes

                        else if (a >= 1 && matriz[i][j] == vetorPalavra[a])
                        {
                            //para cada letra, ele criará um range em volta da letra em questão
                            // para conferir quais posições serão validas, e se sim, ser capaz de pontuar
                            //
                            // ☑    ☑   ☑
                            //    ↖  ↑  ↗
                            // ☑ ← [A] → ☑ 
                            //    ↙  ↓  ↘
                            // ☑    ☑   ☑
                            //  

                            if (
                                posAnteriores[a - 1] == matriz[i - 1][j - 1] || // diagonal superior esqueda
                                posAnteriores[a - 1] == matriz[i][j - 1]     || // cima 
                                posAnteriores[a - 1] == matriz[i + 1][j - 1] || // diagonal superior direita
                                posAnteriores[a - 1] == matriz[i - 1][j]     || // esquerda
                                posAnteriores[a - 1] == matriz[i + 1][j]     || // direita
                                posAnteriores[a - 1] == matriz[i - 1][j + 1] || // diagonal inferior esquerda
                                posAnteriores[a - 1] == matriz[i][j + 1]     || // baixo
                                posAnteriores[a - 1] == matriz[i + 1][j + 1]    // diagonal inferior direta
                                )
                            {

                                //---------------------------------------------------------------------------------------------------------------------------------  
                                //---------------------------------------------------------------------------------------------------------------------------------
                                //
                                // preciso arrumar para que ele faça a verificação para saber se a letra anterior (a posição anterior),
                                //já foi usada, e se essa mesma anterior se encontra adjacente a letra atual (a posição atual) 
                                //
                                //---------------------------------------------------------------------------------------------------------------------------------
                                //---------------------------------------------------------------------------------------------------------------------------------

                                if (posAnteriores.Contains(vetorPalavra[a]))
                                {
                                    finalizar = "erro";
                                    return (pontos, acertos);
                                }
                                else
                                {
                                    posAnteriores[a] = matriz[i][j];
                                    acertos += 1;
                                    acertosTemp += 1;

                                    if (acertosTemp == 2)
                                    {
                                        pontos += 1;
                                        acertosTemp = 0;
                                    }
                                    finalizar = "fim";
                                    break;

                                }
                            }
                            else
                            {
                                finalizar = "erro";
                                return (pontos, acertos);
                            }
                        }

                    }// j

                    if (finalizar == "fim")
                    { break; }

                }// i

               
            }// a

            return (pontos, acertos);
        }

    }
}

