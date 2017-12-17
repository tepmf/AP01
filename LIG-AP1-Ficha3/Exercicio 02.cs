//Exercicio 2. (C4E5) Escreva um programa que devolva o maior de três valores.

using System;
class Program
{
    static void Main(string[] args)
    {
        double val1, val2, val3;
        Console.WriteLine("Insira o primeiro valor a considerar: ");
        val1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor a considerar: ");
        val2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o terceiro valor a considerar: ");
        val3 = Convert.ToDouble(Console.ReadLine());
        if (val1 > val2)
            Console.WriteLine("O maior valor é: {0}", val1);
        else if(val3 > val2)
            Console.WriteLine("O maior valor é: {0}", val3);
        else
            Console.WriteLine("O maior valor é: {0}", val2);
    }
}