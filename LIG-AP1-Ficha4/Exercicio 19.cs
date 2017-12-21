//Exercicio 19. (C5E8) Escreva um programa que calcule o fatorial de um número inteiro fornecido pelo utilizador. Ex.: 5! = 5 * 4 * 3 * 2 * 1 = 120.

using System;
class Program
{
    static void Main(string[] args)
    {
        int inpVal, inpAux;
        Console.WriteLine("Introduza um número: ");
        inpAux = inpVal = Convert.ToInt32(Console.ReadLine());
        Console.Write("{0}! =", inpVal);
        while (inpAux > 1)
        {
            inpAux--;
            inpVal *= inpAux;
        }
        Console.WriteLine(" {0} ", inpVal);
    }
}