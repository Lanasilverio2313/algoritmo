using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o mes (1..12)");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("digite o ano:");
            int ano = int.Parse(Console.ReadLine());


            // Descobre a contidade de dias de um mes
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            //Descobre o dia da semana do primeiro dia do mes
            //0 = Domingo - 6 Sabado
            // gera o primeiro dia do mes infomado com oque o usuario digitar
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;


            //Matriz de 6 semanas e 7 dias 
            int[,] calendario = new int[6, 7];

            int dia = 1;

            //preenche a matriz com os dias do mes
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
        }   
    }
}        
    
                   