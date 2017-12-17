//Exercicio 16. (C3E4) Escreva um programa que calcule a hipotenusa de um triangulo retangulo (utilizar a funcao Math.Sqrt);			
using System;
class Program
{
    static void Main()
    {
        double hipotenusa, cateto1, cateto2;
        Console.WriteLine("Insira o tamanho do cateto 1: ");
        cateto1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o tamanho do cateto 2: ");
        cateto2 = Convert.ToDouble(Console.ReadLine());
        cateto1 = Math.Pow(cateto1, 2);
        cateto2 = Math.Pow(cateto2, 2);
        hipotenusa = Math.Sqrt(cateto1 + cateto2);
        Console.WriteLine("Hipotenusa: {0}", hipotenusa);
    }
}