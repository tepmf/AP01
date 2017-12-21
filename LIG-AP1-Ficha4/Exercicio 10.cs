//Exercicio 10. (C5E27) Escreva um programa que leia uma sequência de números inteiros a partir do teclado e apresente o máximo e o mínimo. O programa termina quando o número lido for zero.

using System;
class Program
{
    static void Main(string[] args)
    {
        int auxiliar, menor, maior;
        Console.WriteLine("Introduza o primeiro valor:");
        auxiliar = menor = maior = Convert.ToInt32(Console.ReadLine());
        while (auxiliar != 0)
       {
            Console.WriteLine("Introduza um novo valor:");
            auxiliar = Convert.ToInt32(Console.ReadLine());
            if (auxiliar > maior)
                maior = a;
            if (auxiliar < menor)
                menor = a;
        
		Console.WriteLine("O Maximo:{0}", maior);
        Console.WriteLine("O Minimo:{0}", menor);
		}
    }
}
