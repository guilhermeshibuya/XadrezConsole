using System;
using Tabuleiro;
using System.Collections.Generic;

namespace Xadrez
{
    class PartidaXadrez
    {
        public TabuleiroXadrez Tab { get; private set; }
        private int _turno;
        private Cor _jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new TabuleiroXadrez(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Branco;
            Terminada = false;
            ColocarPecas();
        }

        public void MovimentarPeca(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);

        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('c', 1).ToPosicao());

            Tab.ColocarPeca(new Rei(Tab, Cor.Branco), new PosicaoXadrez('f', 4).ToPosicao());
        }
    }
}
