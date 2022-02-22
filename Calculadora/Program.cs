using System;

namespace Calculadora

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------Calculadora-----------");
            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, ValorDigitado;

            Console.WriteLine("Digite um número para iniciar os cálculos");
            ValorDigitado = Console.ReadLine();
            valor1 = double.Parse(ValorDigitado);


            Console.WriteLine("Digite a operação ('+, -, *, /')");
            operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            ValorDigitado = Console.ReadLine();
            valor2 = double.Parse(ValorDigitado);

            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{valor1}{'+'}{valor2} = {resultado}");
                    break;

                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{valor1}{'-'}{valor2} = {resultado}");
                    break;

                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{valor1}{'*'}{valor2} = {resultado}");
                    break;

                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{valor1}{'/'}{valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida!");
                    break;
            }

            Console.ReadKey();
        }
    }
}


