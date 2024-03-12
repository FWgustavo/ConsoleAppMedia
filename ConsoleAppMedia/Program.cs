using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a taxa de presença (%) do aluno: ");
            int porcentagem = int.Parse(Console.ReadLine());

            if (media >= 7 && porcentagem >= 75)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media <= 7 && media > 4  && porcentagem >= 75 || porcentagem <= 75)
            {
                Console.WriteLine("Aluno de Recuperação");
                Console.ReadLine();

                Console.WriteLine("Escreva a nota da Recuperação");
                double rec = double.Parse(Console.ReadLine());

                if (rec >= 7)
                {
                    Console.WriteLine("Nota Recuperada, o Aluno Passou");
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado");
                }
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
            }
            Console.ReadKey();
        }
    }
}
