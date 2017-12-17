//Exercicio 27 Escreva um programa que troque entre si o valor contido em duas variaveis inteiras a e b, ou seja, o valor contido em a passa a ser o valor de b e vice-versa.
using System;
class Program
{
    static void Main(string[] args)
    {
        int valA, valB, auxC;
		Console.WriteLine("Insira o valor a atribuir ao a: ");
		valA = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Insira o valor a atribuir ao b: ");
		valB = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Valores Originais")
        Console.WriteLine("Valor a: {0} e Valor b: {1}",valA ,valB);
        auxC = valA;
        valA = valB;
        valB = auxC;
		Console.WriteLine("Valores depois da troca")
        Console.WriteLine("Valor a: {0} e Valor b: {1}", valA, valB);
    }
}
