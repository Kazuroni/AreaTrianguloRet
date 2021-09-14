using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Calculadora de Area Triangulo Retangulo");
            Console.ResetColor();

            Console.WriteLine("enter para continuar");
            Console.ReadLine();

            double valorBase;
            double valorAltura;

            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write("Digite o valor da Base : ");
            Console.ResetColor();
            valorBase = Double.Parse(Console.ReadLine());


            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write("Ok! Base:");
            Console.ResetColor();
            Console.WriteLine($" {valorBase}");

            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write("Agora Digite a Altura...: ");
            Console.ResetColor();
            valorAltura = double.Parse(Console.ReadLine());

            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write("a Altura é: ");
            Console.ResetColor();
            Console.WriteLine($" {valorAltura}");

            Console.WriteLine();
            
            double resultado = valorBase * valorAltura;

            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write($"Hmm =\\ O Resultado da Área..: ");
            Console.ResetColor();
            Console.WriteLine($"{resultado / 2}");            

            Console.WriteLine();
            
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("aperte qualque tecla para finalizar...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}