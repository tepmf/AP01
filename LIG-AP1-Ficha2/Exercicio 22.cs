//Exercicio 22. Escreva um programa que apresente um numero introduzido pelo utilizador em percentagem.

using System;
class Program
{
    static void Main()
    {
        double inpVal;
        Console.WriteLine("Insira o valor: ");
        inpVal = Convert.ToDouble(Console.ReadLine()) / 100;
        Console.WriteLine("Valor em precentagem: {0:P}", inpVal);
    }
}