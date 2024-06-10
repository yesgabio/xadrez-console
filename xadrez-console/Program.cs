﻿using tabuleiro;
using xadrez_console;
using xadrez;

try {

PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.terminada) {

        try {

        Console.Clear();
        Tela.imprimirPartida(partida);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoOrigem(origem);

        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPosiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoDestino(origem, destino);

        partida.executarMovimento(origem, destino);
        }
        catch (Exception e) { 
            Console.WriteLine(e.Message); 
            Console.ReadLine();
        }
    }
    Console.Clear();
    Tela.imprimirPartida(partida);

} catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}


Console.ReadLine();