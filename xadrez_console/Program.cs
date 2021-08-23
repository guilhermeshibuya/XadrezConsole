using System;
using xadrez_console.Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

            Tela.ImprimirTabuileiro(tab);
        }
    }
}
