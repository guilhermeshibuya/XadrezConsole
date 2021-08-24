using System;
using Tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                
                tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(3, 4));

                Tela.ImprimirTabuileiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
