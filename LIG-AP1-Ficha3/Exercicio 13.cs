//Exercicio 13. Para doar sangue é necessário ter entre 18 e 67 anos. Escreva um programa que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não.

using System;
class Program
{
    static void Main(string[] args)
    {
        int idade;
        string resultado;
        Console.WriteLine("Insira por favor a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        resultado = (idade > 18 && idade < 67) ? "Pode." : "Não pode.";
        Console.WriteLine(resultado);
    }
}
