//Exercicio 5. Implemente um programa que calcule o salario semanal a pagar a um empregado, tendo em atenção que todas as horas que este trabalha para além das 40 horas serão pagas a dobrar. Lê do utilizador os valores de horas trabalhadas e o valor do salário por hora.

using System;
class Program
{
    static void Main(string[] args)
    {
        double valTHora, valSHora, valReceb;
        Console.WriteLine("Insira o valor de horas trabalhadas: ");
        valTHora = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o valor a considerar de salário por hora: ");
		valSHora = Convert.ToDouble(Console.ReadLine());
		if (valTHora - 40 < 0)
			valReceb = valTHora * valSHora;
		else
			valReceb = ((valTHora - 40) * valSHora * 2) + (valSHora * 40);
		Console.WriteLine("O valor a receber é de: {0}",valReceb);
    } 
}