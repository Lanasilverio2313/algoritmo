using System;


namespace _04_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variavel
            //Sintaxa: tipo nomeVariavel = Valor
            string nome = ("lana");

            //Reatribuiçao de valor em uma variavel
            nome = "Beltrano";
            Console.WriteLine(nome);

            //Declaraçao de vetores
            //Sintaxe: tipo[] nomeVariavel = {Valor, valor2,valor 2;
            string[] nomes = { "fulano de tal", "Beltrano", "sicrano","jose","joao","maria" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            
            //Loop FOR
            //for(indice, controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            {
               Console.WriteLine("{0}° Nome: {1}",i+1, nomes[i] );               
            }

            //impressao dos 100 primeiros numeros pares
            for (int i = 0; i <= 100; i += 2)
            {

                Console.WriteLine("numero: {0}", i);
            }

            //Loop foreach
            //Sintaxe: foreach( vareavel in vetor )
            foreach (string varNome in nomes)
            {
                Console.WriteLine("Nome: {0}", varNome); 
            } 

        }
        
    }

}
