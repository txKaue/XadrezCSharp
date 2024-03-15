using System;
using System.Collections.Generic;


namespace Xadrez
{
    internal class Tabuleiro
    {

        public static void Montar()
        {
            int columns = 8;
            int rows = 8;
            int montador = 0;
            List<int> montabase = new List<int>() { 7, 15, 23, 31, 39, 47, 55 };

            // Montando vazio

            string[,] tabuleiro = new string[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tabuleiro[i, j] = "#";
                }
            }


            // Aqui eu vou começar a colocar as peças

            char[] pecas = new char[6] {'T','C','B','Q','K','P'};

            tabuleiro[0, 0] = pecas[0].ToString();
            tabuleiro[0, 7] = pecas[0].ToString();
            tabuleiro[7, 0] = pecas[0].ToString();
            tabuleiro[7, 7] = pecas[0].ToString();

            tabuleiro[0, 1] = pecas[1].ToString();
            tabuleiro[0, 6] = pecas[1].ToString();
            tabuleiro[7, 1] = pecas[1].ToString();
            tabuleiro[7, 6] = pecas[1].ToString();

            tabuleiro[0, 2] = pecas[2].ToString();
            tabuleiro[0, 5] = pecas[2].ToString();
            tabuleiro[7, 2] = pecas[2].ToString();
            tabuleiro[7, 5] = pecas[2].ToString();

            tabuleiro[0, 3] = pecas[3].ToString();
            tabuleiro[7, 3] = pecas[3].ToString();

            tabuleiro[0, 4] = pecas[4].ToString();
            tabuleiro[7, 4] = pecas[4].ToString();

            int x = 0;
            int h = 1;
            while (x < 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    tabuleiro[h, i] = pecas[5].ToString();
                }
                h = 6;
                x++;
            }


                


            // Aqui é eu mostrando o tabuleiro

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    if (montabase.Contains(montador))
                    {
                        Console.WriteLine(" " + tabuleiro[i, j] + " \n");
                    }
                    else
                    {
                        Console.Write(" " + tabuleiro[i, j] + " ");
                    }

                    montador += 1;

                }
            }

            

            

        }
    }
}
