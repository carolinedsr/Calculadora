using System;

namespace Calculadora

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------Calculadora-----------");
            double valor1 = 0, valor2 = 0;
            string ValorDigitado="";



            Console.WriteLine("Digite um número para iniciar os cálculos");
            ValorDigitado = Console.ReadLine();
            valor1 = double.Parse(ValorDigitado);

            Console.WriteLine("Digite o segundo número: ");
            ValorDigitado = Console.ReadLine();
            valor2 = double.Parse(ValorDigitado);

            Console.WriteLine("Adição: {0}",valor1 + valor2);
            Console.WriteLine("Subtração: {0}", valor1 - valor2);
            Console.WriteLine("Multiplicação: {0}", valor1 * valor2);
            Console.WriteLine("Divisão: {0}",valor1 / valor2);

            Console.ReadKey();
        }
    }
}


