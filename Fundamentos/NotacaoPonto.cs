using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " world ").Replace(" world ", " mundo ");
            Console.WriteLine(saudacao);

            string ValorImportante = null;
            Console.WriteLine(ValorImportante?.Length);




        }
    }
}
