using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
    private readonly iJogador _jogador1;

    private readonly iJogador _jogador2;

    public JogoFODA(iJogador jogador1, iJogador jogador2)
    {
      _jogador1 = jogador1;
      _jogador2 = jogador2;
    }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Chutar());
            System.Console.Write(_jogador1.Correr());
            System.Console.Write(_jogador1.Passar());
            //
            System.Console.Write(" \n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogador2.Chutar());
            System.Console.Write(_jogador2.Correr());
            System.Console.Write(_jogador2.Passar());
        }


    }
}