//Exercicio 18. Desenvolva um programa para ler um número de 1 a 7 e informar o dia da semana correspondente, sendo domingo o dia número 1. Se o número não corresponder a um dia da semana, é mostrada uma mensagem de erro.
using System;
class Program
{
    static void Main(string[] args)
    {
        int diaInput;
        Console.WriteLine("Introduza por favor o número a avaliar: ");
        diaInput = Convert.ToInt32(Console.ReadLine());
        switch (diaInput)
		{
			case 1:
				Console.WriteLine("Domingo");
                break;
			case 2:
				Console.WriteLine("Segunda-Feira");
                break;
            case 3:
				Console.WriteLine("Terça-Feira");
                break;
            case 4:
				Console.WriteLine("Quarta-Feira");
                break;
            case 5:
				Console.WriteLine("Quinta-Feira");
                break;
            case 6:
				Console.WriteLine("Sexta-Feira");
                break;
            case 7:
				Console.WriteLine("Sábado");
                break;
            default:
				Console.WriteLine("Informação introduzida inválida");
                break;
        }
    }
}