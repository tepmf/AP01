//Exercicio 8. (C2E16) Escreva um programa que apresente os seguintes numeros arredondados a duas casas decimais: 4,78905; 4,7; 5,8954; 5.
using System;
class program
{
    static void Main(string[] args)
    {
        double a, b, c, d;
        a = 4.78905;
        b = 4.7;
        c = 5.8954;
        d = 5;
        Console.WriteLine("{0}", Math.Round(a, 2));
        Console.WriteLine("{0}", Math.Round(b, 2));
        Console.WriteLine("{0}", Math.Round(c, 2));
        Console.WriteLine("{0}", Math.Round(d, 2));
    }
}