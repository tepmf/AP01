//Exercicio 15. (C4E12) Escreva um programa que apresente o número de dias de um mês escolhido pelo utilizador. No caso do mês de fevereiro apresente "28 ou 29 dias".

using System;
class Program
{
    static void Main(string[] args)
    {
        int input;
        Console.WriteLine("Introduza o número do mês: ");
        input = Convert.ToInt32(Console.ReadLine());
        if (input == 1 || input == 3 || input == 5 || input == 7 || input == 8 || input == 10 || input == 12)
            Console.WriteLine("O mês em questão tem 31 dias.");
        else if (input == 4 || input == 6 || input == 9 || input == 11)
            Console.WriteLine("O mês em questão tem 30 dias.");
        else if (input == 2)
            Console.WriteLine("O mês em questão tem 28 ou 29 dias.");
        else
            Console.WriteLine("Informação introduzida inválida");
    }
}
