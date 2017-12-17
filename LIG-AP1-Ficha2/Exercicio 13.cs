//Exercicio 13. (C3E2) Escreva um programa que peca o nome e o apelido ao utilizador e imprima o apelido seguido de uma virgula e do nome prorpio.
using System;
class program
{
	static void Main(string[] args)
	{
		string nomeP, nomeA;
		Console.WriteLine("Escreva o seu nome proprio");
		nomeP = Console.ReadLine();
		Console.WriteLine("Escreva o seu aplelido");
		nomeA = Console.ReadLine();		
		Console.WriteLine("{0},{1}",nomeA,nomeP);
	}
}