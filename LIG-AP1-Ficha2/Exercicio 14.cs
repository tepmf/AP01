//Exercicio 14. (C2E24) Escreva um programa que demonstre a leitura de dados numericos a partir do teclado.
using System;
class program
{
	static void Main(string[] args)
	{
		double numero;
		Console.WriteLine("Insira um numero");
		numero = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("O numero introduzido foi o {0}",numero);
	}
}