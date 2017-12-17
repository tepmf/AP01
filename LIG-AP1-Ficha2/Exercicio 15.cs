// 15. Escreva um programa que calcule a area e o perimetro de um quadrado.
using System;
class Program
{
    static void Main()
    {
        double lado;
        Console.WriteLine("Insira o tamanho do lado:");
        lado = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Area: {0}, Perimetro: {1}", lado * lado, 4 * lado);
    }
}