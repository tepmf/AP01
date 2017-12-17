//Exercicio 21. Escreva um programa que converta um valor em segundos para horas, minutos e segundos.

using System;
class Program
{
    static void Main()
    {
        int segVal, minVal, horVal, inpVal;
        Console.WriteLine("Insira o valor em segundos: ");
        inpVal = Convert.ToInt32(Console.ReadLine());
        horVal = inpVal / 3600;
        minVal = inpVal % 3600 / 60;
        segVal = inpVal % 3600 % 60;
        Console.WriteLine("Conv: Horas {0}, Minutos {1}, Segundos {2}", horVal, minVal, segVal);
    }
}