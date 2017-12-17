//Exercicio 10. (C2E21) Escreva um programa que faca uso de operadores combinados (ex.:soma += 2).
using System;
class program
{
    static void Main(string[] args)
    {
        double a, b;
        a = 20;
        Console.WriteLine("Insira um valor: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Valor a: {0} ", a);
        Console.WriteLine("Valor b: {0} ", b);
        b += a;
        Console.WriteLine("Valor a: {0} ", a);
        Console.WriteLine("Valor b: {0} ", b);
    }
}