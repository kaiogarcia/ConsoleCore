using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
       public readonly string Nome;
       public Jogador1(String nome = "RONALDO")
       {
           Nome = nome;
        }

        //chutar
        public string Chutar()
        {
            return $"{Nome} está chutando \n";
        }
        //correr

        public string Correr()
        {
            return $"{Nome} está correndo \n";
        }

        //passar

        public string Passar()
        {
            return $"{Nome} está passando";
        }

    }
}