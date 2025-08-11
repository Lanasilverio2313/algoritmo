using System;


namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;

            //!negaçao: inverte o valor  booleano
            //!false = true
            // while (digitacoaValida== false)
            while (!digitacaoValida) {

                Console.WriteLine("digite um numero inteiro");
                digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);

                //cosole.WriteLine(tabuada do {0}", multiplicador);
                //Interpolaçao de string $
                Console.WriteLine($"TABUADA DO {multiplicando}");
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    produto = multiplicando * multiplicando;
                    //console.WhiteLine("{0} x {1} = {2}", multiplicando, multiplicador produto);
                    Console.WriteLine($"{multiplicando} x {multiplicador} = {produto}");
                }
            }

        }
    }
}
