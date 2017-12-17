//Exercicio 4. Escreva um programa que converta um valor real positivo para um inteiro por arredondamento.

using System;
class Program
{
    static void Main(string[] args)
    {
        double valorReal;
        int valorInteiro;
        Console.WriteLine("Insira um valor real positivo: ");
        valorReal = Convert.ToDouble(Console.ReadLine());
        valorInteiro = Convert.ToInt32(Math.Round(valorReal, 0));
        Console.WriteLine("Valor {0}", valorInteiro);
    }
}