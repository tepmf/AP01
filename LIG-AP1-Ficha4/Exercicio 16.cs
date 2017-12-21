//Exercicio 16. Escreva um programa que imprima, em várias linhas, os 25 primeiros múltiplos de um dado número inteiro introduzido pelo utilizador. Cada uma das linhas escritas deve conter 5 múltiplos do número especificado.

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int inpAux = 0;
        int inpVal;
        Console.WriteLine("Insira um número: ");
        inpVal = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 25; i++)
        {
            inpAux = inpVal * i;
            if (i % 5 == 0)
                Console.WriteLine(" {0:D2} ", inpAux);
            else
                Console.Write(" {0:D2} ", inpAux);
        }
    }
}