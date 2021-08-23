using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(Posicao posicao, TabuleiroXadrez tab, Cor cor)
        {
            Posicao = posicao;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }
    }
}
