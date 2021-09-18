using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI =3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            Console.WriteLine("===============================");

            double Raio = 6.5;
            const double Pi = 3.14;

            Raio = 5.6;
            double Area = Pi * Raio * Raio;
            Console.WriteLine(Area);
            Console.WriteLine("A Área é " + Area);
            Console.WriteLine("===============================");
            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);
            Console.WriteLine("===============================");
           
            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            Console.WriteLine("===============================");


            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);
            Console.WriteLine("===============================");

            
            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);
            Console.WriteLine("===============================");

            int menorValorInt = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);
            Console.WriteLine("===============================");

            uint PopulacaoBrasileira = 207_600_000;
            Console.WriteLine("A População Brasileira " + PopulacaoBrasileira);
            Console.WriteLine("===============================");

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor é " + menorValorLong);
            Console.WriteLine("===============================");

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é " + populacaoMundial);
            Console.WriteLine("===============================");

            float precoDoComputador = 1999.99f;
            Console.WriteLine("Preço do Computador " + precoDoComputador);
            Console.WriteLine("===============================");

            double valorDeMercadoDaApple = 10000000000000000.00;
            Console.WriteLine("Valor Da Apple " + valorDeMercadoDaApple); //Mais usado dos reais
            Console.WriteLine("===============================");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);
            Console.WriteLine("===============================");

            char letra = 'a';
            Console.WriteLine("Letra " + letra);
            Console.WriteLine("===============================");

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);


        }


    }
}
