using System;
using System.Globalization;

namespace Vetor {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dedico meus estudos ao meu filho MIGUEL MALTA FUKUTA");
            Console.WriteLine("====================================================");

            Console.WriteLine("Quantas Posições:");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double soma = 0;
            for (int x=0; x < n; x++) {

                Console.WriteLine("Entre com a valor Posição {0} :", x);
                vect[x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[x];

            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Média de Altura: " + (soma/n).ToString("N2",CultureInfo.InvariantCulture));



        }
    }
}
