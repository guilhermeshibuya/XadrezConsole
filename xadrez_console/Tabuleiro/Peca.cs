using System;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(TabuleiroXadrez tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
