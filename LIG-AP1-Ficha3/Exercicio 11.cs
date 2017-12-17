//Exercico 11. Escreva um programa que leia um número e indique se é positivo, negativo ou nulo.

using System;
class Program
{
    static void Main(string[] args)
    {
        double numero;
        Console.WriteLine("Insira um número: ");
        numero = Convert.ToDouble(Console.ReadLine());
        if (numero == 0)
            Console.WriteLine("Nulo");
        else if (numero > 0)
            Console.WriteLine("Positivo");
        else
            Console.WriteLine("Negativo");
    }
}