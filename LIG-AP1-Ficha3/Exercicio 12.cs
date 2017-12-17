//Exercicio 12. Escreva um programa que verifique se um caracter introduzido pelo utilizador é maiúsculo, minúsculo ou outro.

using System;
class Program
{
    static void Main(string[] args)
    {
        char caracter;
        Console.WriteLine("Introduza um caracter: ");
        caracter = Convert.ToChar(Console.ReadLine());
        if (caracter <= 'Z' && caracter >= 'A')
            Console.WriteLine("Maiusculo");
        else if (caracter <= 'z' && caracter >= 'a')
            Console.WriteLine("Minusculo");
        else
            Console.WriteLine("Outro");
    }
}
