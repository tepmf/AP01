//Exercicio 24 (C3E7) Escreva um programa que mostre calcule a media final a AP1, arredondada a 0 casas decimais. Devera pedir o nome e as notas das duas frequencias.

using System;
class Program
{
    static void Main()
    {
        double notaFreq1, notaFreq2, notaMedia;
        string nomeAluno;
        Console.WriteLine("Insira o seu nome por favor: ");
        nomeAluno = Console.ReadLine();
        Console.WriteLine("Insira nota da primeira frequencia: ");
        notaFreq1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira nota da segunda frequencia: ");
        notaFreq2 = Convert.ToDouble(Console.ReadLine());
        notaMedia = notaFreq1 + notaFreq2;
        Console.WriteLine("Caro/a {0}, a nota final é: {1:F0}", nomeAluno, notaMedia / 2);
    }
}