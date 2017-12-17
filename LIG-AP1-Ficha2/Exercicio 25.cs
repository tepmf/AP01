//Exercicio 25. (C3E8) Escreva um programa que calcule a despesa media diaria que um turista despendeu numa viagem de quatro dias ao Porto, sabendo que cada dia gastou mais 20% do que no dia anterior.

using System;
class Program
{
    static void Main()
    {
        double gastoBase;
        Console.WriteLine("Insira o valor gasto no primeiro dia: ");
        gastoBase = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < 4; i++)
            gastoBase = gastoBase * 1.20;
        Console.WriteLine("O valor gasto foi de: {0:F2}", gastoBase);

    }
}