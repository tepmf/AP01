//Exercicio 8. Escreva um programa que veríque se um determinado número introduzido é par.

using System;
class Program
{
    static void Main(string[] args)
    {
        double valConf;
        Console.WriteLine("Insira um valor");
        valConf = Convert.ToDouble(Console.ReadLine());
        if (valConf % 2 == 0)
            Console.WriteLine("Valor par");
                        
        else
            Console.WriteLine("Valor impar");
    } 
}