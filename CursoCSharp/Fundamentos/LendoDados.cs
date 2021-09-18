using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu Nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("================");

            Console.WriteLine("Qual é a Sua idade?");
            string idade = (Console.ReadLine());
            Console.WriteLine("================");

            Console.WriteLine("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine(),
              CultureInfo.InvariantCulture);
            Console.WriteLine("================");

            Console.WriteLine($"{nome}\n{idade}\n");
            Console.WriteLine(salario.ToString("C"));
            

        }
    }
}
