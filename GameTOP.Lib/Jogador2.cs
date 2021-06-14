using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador2 : iJogador
  {
    public string Chutar()
    {
      return "Maradona estas pateando \n";
    }

    public string Correr()
    {
      return "Maradona estas corriendo \n";
    }

    public string Passar()
    {
      return "Maradona estas pasando";
    }
  }
}