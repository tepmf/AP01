//Exercicio 13. (C5E13) Escreva um programa que aceite um número inteiro e calcule a soma dos seus dígitos. Altere a função escrita no programa anterior.

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
            result = result + input % 10;
            input = input / 10;
        }
        Console.WriteLine("Resultado final: {0}", result);
    }
}