//Exercicio 7. (C2E13) Escreva um programa que apresente no ecra a parte inteira de um numero.

using System;
class program
{
    static void Main(string[] args)
    {
		double a = 8.34;
		int b;
		b = Convert.ToInt32(a);
        Console.WriteLine("{0}", b);
    }
}
/*V2
using System;
class program
{
    static void Main(string[] args)
    {
        double a = 8.34363464;
        Console.WriteLine("{0:F4}", a);
    }
}
*/