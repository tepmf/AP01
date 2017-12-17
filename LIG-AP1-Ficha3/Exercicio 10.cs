//Exercico 10. Escreva um programa que veríque se um determinado ano introduzido é bissexto.

using System;
class Program
{
    static void Main(string[] args)
    {
        double val;
        Console.WriteLine("Insira um ano");
        val = Convert.ToDouble(Console.ReadLine());
        if ((val % 4 == 0 && val % 100 != 0) || (val % 400 == 0))
            Console.WriteLine("Ano Bissexto");

        else
            Console.WriteLine("Ano não Bissexto");
    }
}