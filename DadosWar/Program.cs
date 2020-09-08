using System;

namespace DadosWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int dadoAmarelo, dadoVermelho, ataque =0, defesa =0;
            Random Amarelo = new Random();
            Random Vermelho = new Random();
           
            for (int i = 1; i <= 3; i++) { 
                dadoVermelho = Vermelho.Next(1,6);
                dadoAmarelo = Amarelo.Next(1, 6);
                if (dadoVermelho > dadoAmarelo)
                {
                    ataque++;
                    Console.WriteLine("Dado vermelho = " + dadoVermelho + " dado amarelo = "+dadoAmarelo);
                    Console.WriteLine("Ataque ganhou");
                }
                else
                {
                    defesa++;
                    Console.WriteLine("Dado vermelho = "+ dadoVermelho+ " dado amarelo = "+ dadoAmarelo);
                    Console.WriteLine("Defesa ganhou");
                }
                             
            }

            Console.WriteLine("RESULTADO FINAL:");
            Console.WriteLine("Ataque: "+ataque);
            Console.WriteLine("Defesa: "+ defesa);

        }
    }
}
