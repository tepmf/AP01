// 5. Escreva um programa que receba dois numeros inteiros e gere os numeros inteiros que estao no intervalo compreendido por eles.

using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Introduza o maior numero:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduza o menor numero:");
        b = Convert.ToInt32(Console.ReadLine());
        while (a > b +1 )
        {
            a -= 1;
            Console.WriteLine("A Imprimir {0}",a);
        }
    }
}
