//Exercicio 18. Escreva um programa que determine os divisores de um número inteiro introduzido pelo utilizador.

using System;
class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Insira o número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= numero / 2; i++)
        {
            if (numero % i == 0)
                Console.WriteLine("O seguinte valor é divisor: {0}", i);
        }
    }
}