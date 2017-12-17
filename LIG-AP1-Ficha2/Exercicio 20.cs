/*Exercicio 20. Altere o programa anterior por forma a que o valor da taxa de IVA seja tambem um valor fornecido pelo utilizador.
Exercicio 19 Escreva um programa que leia o preco base de um determinado produto e calcule o seu valor de venda ao publico (ou seja, valor acrescido da taxa de IVA a 21%).*/


using System;
class Program
{
    static void Main()
    {
        double precoBase, ivaVal;
        Console.WriteLine("Insira o valor base do produto: ");
        precoBase = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insira actual do IVA (no formato 1,xx)");
        ivaVal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O valor com iva: {0}", precoBase * ivaVal);
    }
}