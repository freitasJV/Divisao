using System;
using System.Globalization;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o número de divisões que deseja realizar: ");
                int qtde = int.Parse(Console.ReadLine());
                double numerador, denominador, resultado;
                for (int i = 1; i <= qtde; i++)
                {
                    Console.Write("Digite o númerador e denominador, respectivamente, separados por espaços: ");
                    string[] entrada = Console.ReadLine().Split(' ');

                    numerador = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                    denominador = double.Parse(entrada[1], CultureInfo.InvariantCulture);

                    if (denominador == 0)
                        Console.WriteLine("Divisão Impossível");
                    else
                    {
                        resultado = numerador / denominador;
                        Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
