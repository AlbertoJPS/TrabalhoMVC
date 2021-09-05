using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMVC_02.Controller
{
    class Controladores
    {
        public static int Pontos(string[][] matriz, string posicao, out int acertos)
        {
            List<string> listagem = new List<string>();
            acertos = 0;
            int acertosTemp = 0;
            int pontos = 0;
            string numProcura = "";
            //bool confere = false;


            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == posicao[0].ToString())
                    {
                        //confere = true;
                        numProcura = matriz[i][j];
                        acertos += 1;
                        acertosTemp += 1;
                        
                        if (acertosTemp == 2)
                        {
                            pontos += 1;
                            acertosTemp = 0;
                        }
                        
                        i = 20;
                        break;
                    }
                }
            }
            //if (confere)
            //{
            //    for (int k = 1; k < nu.Length; k++)
            //    {
            //        for (int i = 0; i < matriz.Length; i++)
            //        {
            //            for (int j = 0; j < matriz[i].Length; j++)
            //            {
            //                if (matriz[i][j] == numProcura)
            //                {
            //                    try
            //                    {
            //                        lista.Add(matriz[i - 1][j - 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i][j - 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i - 1][j]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i + 1][j + 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i + 1][j - 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i - 1][j + 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i + 1][j]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    try
            //                    {
            //                        lista.Add(matriz[i][j + 1]);
            //                    }
            //                    catch (Exception)
            //                    {
            //                    }
            //                    for (int l = 0; l < lista.Count; l++)
            //                    {
            //                        if (nu[k].ToString() == lista[l])
            //                        {
            //                            numProcura = lista[l];
            //                            points += 0.5;
            //                            i = 2;
            //                            j = 2;
            //                            break;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{

            //}

            return pontos;
        }
    }
}

