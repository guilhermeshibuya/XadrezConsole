﻿using System;
using xadrez_console.Tabuleiro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuileiro(TabuleiroXadrez tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(tab.Peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}