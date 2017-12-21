// Exercicio 7. Escreva um programa que gere a tabuada de 1 a 10 de qualquer número inteiro. O utilizador deve informar de qual número que ele deseja ver a tabuada.

using System;
class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Introduza o numero do qual pretende visualizar a tabuada: ");
        numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
            Console.WriteLine("{0} * {1} = {2}", i, numero, i * numero);
    }
}
