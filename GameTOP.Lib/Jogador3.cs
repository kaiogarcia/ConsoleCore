using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador3 : iJogador
  {
    public string Chutar()
    {
      return "teste chuta \n";
    }

    public string Correr()
    {
      return "teste corre \n";
    }

    public string Passar()
    {
      return "teste passe \n";
    }
  }
}