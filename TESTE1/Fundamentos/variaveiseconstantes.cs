using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class variaveiseconstantes
    {public static void Executar()
        {// area da circunferencia
            double raio = 4.5;
            const double PI = 4.5; 

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é" + (area + 1000) );

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45;


        }
    }
}
