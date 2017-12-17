//Exercico 9. Escreva um programa que determine se um determinado número inteiro é positivo e par.

using System;
class Program
{
    static void Main(string[] args)
    {
        int valConf;
        Console.WriteLine("Insira um número");
        valConf = Convert.ToInt32(Console.ReadLine());
        if ((valConf % 2 == 0) && (valConf > 0))
            Console.WriteLine("Valor positivo e par");

        else
            Console.WriteLine("Valor não positivo ou par");
    }
}
