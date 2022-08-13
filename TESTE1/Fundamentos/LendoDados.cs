using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {public static void Executar()
        {
            Console.Write("Qual é o nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é o sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual e´o seu salário");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} {salario}");


        }
    }
}
