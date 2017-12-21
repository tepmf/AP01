// Exercicio 9. Escreva um programa que peça 10 números inteiros, calcule e mostre a quantidade de números pares e a quantidade de números ímpares.

using System;
class Program
{
    static void Main(string[] args)
    {
        int valPar, valImp, valInt;
        valPar = valImp = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Introduza um numero:");
            valInt = Convert.ToInt32(Console.ReadLine());
            if (valInt % 2 == 0)
                valPar++;
            else
                valImp++;
        }
        Console.WriteLine("Números pares: {0}", valPar);
        Console.WriteLine("Números impares: {0}", valImp);
    }
}
