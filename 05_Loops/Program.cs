using System;
using System.Linq;


namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [100];
            string continuar = "S";
            
            //sera meu indice para atribuiçao no vetor
            int contador = 0;

            //Loop while
            //Sintaxe: while(expessao booleana

            while (continuar.ToUpper() == "S") // metado Toupper converte texto para maiusculo
            {

                Console.WriteLine("Digite o {0}ª nome:", contador + 1);
                //Apped adiciona um item no vetor
                nomes[contador] = Console.ReadLine();

            
                contador++;
                Console.WriteLine("deseja continuar? (S/N)");
                continuar = Console.ReadLine();

                Console.WriteLine("nomes informados");
                foreach (string str in nomes)
                {
                    // "!= significa diferente
                    if (str != null)
                {
                        Console.WriteLine(str);
                    }

                        
                    
                }
            }

            }
        }
    }
