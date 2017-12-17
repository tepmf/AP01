//Exercicio 23. Escreva um programa que apresente ao utilizador a sua idade daqui a vinte anos.

using System;
class Program
{
	static void Main()
	{
		int val;
		Console.WriteLine("Insira a sua idade actual: ");
		val = Convert.ToInt32(Console.ReadLine());
		val = val + 20;
		Console.WriteLine("Daqui a vinte anos terá {0}", val);
	}
}