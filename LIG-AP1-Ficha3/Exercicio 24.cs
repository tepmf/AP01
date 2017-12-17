//Exercicio 24. (C4Ex6) Operador ternário (? :). Escreva um programa que apresente a mensagem "Parabéns" se um aluno teve nota superior a 10 e "Marque um novo exame", caso contrário.

using System;
class Program
{
    static void Main(string[] args)
    {
        int notaAlun;
		string imprResu;
        Console.WriteLine("Insira a nota do aluno:");
        notaAlun = Convert.ToInt32(Console.ReadLine());
		imprResu = (notaAlun > 10) ? "Parabéns" : "Marque um novo exame";
        Console.WriteLine(imprResu);
    }
}