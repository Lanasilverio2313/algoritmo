using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que digite o CPF
            Console.Write("Digite seu CPF (somente números): ");
            string cpf = Console.ReadLine();
            {

                // Remove todos os caracteres que não sejam números
                Console.WriteLine("digite algo com numero:");

                // Remova tudo que nao for digito (0-9)
                string SomenteNumeros = Regex.Replace(cpf, "[^0-9]", "");
                Console.WriteLine($" Somente numeros: {SomenteNumeros}");
            }

            {
                // validar se tem 11 digitos
                if (cpf.Length != 11) ;
                Console.WriteLine("CPF deve conter 11 digitos");
                return;
            }
            {
                // validar cpfs com todos numeros
                if (cpf == "11111111111" || cpf == "22222222222") ;
            }
            {
                Console.WriteLine("CPF invalido! Numeros repetidos nao sao permitidos");
                return ;
            }
            {
                //4 - calculo do primeiro digito verificado
                int soma = 0;
                char[] cpfVetor = cpf.ToCharArray();

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpfVetor[i].ToString()) * (10 - i);

                }
                {
                    int resto = soma % 11;

                    int digX = 0;
                    if (resto > 2) ;
                    
                    digX = 11 - resto;

                }
                {  

                
                 
                
            }
        }

          

    }
}
