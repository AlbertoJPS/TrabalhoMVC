using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMVC_02.Model
{
    class Gerador
    {
        public static string iniciaTabuleiro(string matrix1, string matrix2)
        {
            Random aleatorio = new Random();
            int matrix = aleatorio.Next(1, 3);

            if (matrix == 1)
            {
                return matrix1;
            }
            else
            {
                return matrix2;
            }
        }
        public static string iniciaTabuleiro(string matrix1, string matrix2, string matrix3)
        {
            Random aleatorio = new Random();
            int matrix = aleatorio.Next(1, 4);

            if (matrix == 1)
            {
                return matrix1;
            }
            else if (matrix == 2)
            {
                return matrix2;
            }
            else
            {
                return matrix3;
            }
        }
    }
}
