using System;



namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanhoMB = 0;
            double velocidadeMbps = 0;
            bool entradaValida = false;

            // Loop para validar tamanho do arquivo
            while (!entradaValida)
            {
                Console.Write("Informe o tamanho do arquivo (MB): ");
                string input = Console.ReadLine();

                entradaValida = double.TryParse(input, out tamanhoMB) || tamanhoMB > 0;

                if (!entradaValida)
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            }

            entradaValida = false;

            // Loop para validar velocidade da internet
            while (!entradaValida)
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                string input = Console.ReadLine();

                entradaValida = double.TryParse(input, out velocidadeMbps) || velocidadeMbps > 0;

                if (!entradaValida)
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            }

            // Cálculo do tempo em segundos
            double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;

            // Converter para minutos
            double tempoMinutos = tempoSegundos / 60;

            // Exibir resultado com 2 casas decimais, vírgula no lugar do ponto (formato pt-BR)
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos.ToString("F2")} minutos");
        }
    }
}
  
    
     
              








    

