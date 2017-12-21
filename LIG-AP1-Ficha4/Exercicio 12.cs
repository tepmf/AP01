//Exercicio 12. Escreva um programa que aceite um número inteiro e devolva um novo número correspondente a trocar os dígitos do primeiro. Por exemplo, dadoo número 3456 devolver 6543.

using System;
class Program
{
    static void Main(string[] args)
    {
        int input, result = 0;
        Console.WriteLine("Introduza um numero:");
        input = Convert.ToInt32(Console.ReadLine());
        while (input > 0)
        {
            result = result * 10 + input % 10;
            input = input / 10;
        }
        Console.WriteLine("Resultado final: {0}", result);
    }
}