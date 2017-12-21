// 2. (C5E2) Escreva um programa que imprima a soma de N números inteiros.

using System;
class Program
{
    static void Main(string[] args)
    {
        int numero;
        int soma = 0;
        Console.WriteLine("Introduza um numero:");
        numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numero; i++)
            soma += i;
        Console.WriteLine("{0}",soma);
    }
}
