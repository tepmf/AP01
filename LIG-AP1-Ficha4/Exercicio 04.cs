// 4. (C5E4) Escreva um programa que imprima no ecrã um retângulo com o símbolo "X" sabendo a sua largura e comprimento.

using System;
class Program
{
    static void Main(string[] args)
    {
        int compVal, largVal;
        Console.WriteLine("Introduza o comprimento:");
        compVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduza a Largura:");
        largVal = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < compVal; i++)
        {
            if (i == 0 || i == compVal - 1)
            {
                for (int j = 0; j < largVal; j++)
                {
                    if (j < largVal -1 )
                        Console.Write("X");
                    else
                        Console.WriteLine("X");
                }
            }
            else
            {
                for (int g = 0; g < largVal; g++)
                {
                    if (g == 0)
                        Console.Write("X");
                    else if (g < largVal - 1)
                        Console.Write(" ");
                    else
                        Console.WriteLine("X");
                }
            }
        }
    }
}
