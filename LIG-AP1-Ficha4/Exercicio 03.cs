// 3. (C5E3) Escreva um programa que imprima no ecr~a apenas os números ímpares entre 1 e 50.

using System;
class Program
{
    static void Main(string[] args)
    {
        int numero = 50;
        for (int i = 0; i < numero; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine("{0}", i);
        }
    }
}
