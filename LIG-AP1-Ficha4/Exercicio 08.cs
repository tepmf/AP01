// Exercicio 8. Escreva um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número. Não utilize a função de potência da linguagem.

using System;
class Program
{
    static void Main(string[] args)
    {
        int baseVal, expoVal, auxVal;
        Console.WriteLine("Introduza o base:");
        auxVal = baseVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduza o expoente:");
        expoVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O valor base é {0} e o expoente {1}", baseVal, expoVal);
        for (int i = 2; i <= expoVal ; i++)
        {
            auxVal *= baseVal;
        }

        Console.WriteLine("Resultado: {0}", auxVal);
    }
}
