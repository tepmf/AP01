//Exercicio 11. Escreva um programa que leia uma sequência de números inteiros a partir do teclado e acumule unicamente a soma dos inteiros positivos. O programa termina quando o número lido for zero.

using System;
class Program
{
    static void Main(string[] args)
    {
        int input, soma;
        input = soma = 0;
        do
        {
            Console.WriteLine("Introduza um numero:");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > -1)
                soma += input;
        }
        while (input != 0);
        Console.WriteLine("Valor Final: {0}", soma);
    }
}