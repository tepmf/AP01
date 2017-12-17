//Exercicio 26. (C3E10) Num determinado stand de automoveis, os vendedores ganham um salario mensal base X, uma comissão de Y euros por cada automovel que vendem e uma percentagem P sobre o valor das vendas V que efetuarem. Escreva um programa que calcule e imprima o salario que um vendedor vai auferir este mês.

using System;
class Program
{
	static void Main()
	{
		double vencBase,vencCom,vencPerc,comVal,percVal;
		//Vencimento Base
		Console.WriteLine("Insira o valor do vencimento base: ");
		vencBase = Convert.ToDouble(Console.ReadLine());
		//Comissão por cada automóvel vendido
		Console.WriteLine("Insira o valor de comissao por cada automovel vendido: ");
		comVal = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Insira o numero de automoveis vendidos: ");
		vencCom = Convert.ToDouble(Console.ReadLine()) * comVal;		
		//Percentagem pelo valor das vendas
		Console.WriteLine("Insira o valor da percentagem a receber (de zero a cem) sobre o valor das vendas: ");
		percVal = Convert.ToDouble(Console.ReadLine()) / 100;		
		Console.WriteLine("Insira o valor a considerar de vendas efectuado: ");
		vencPerc = Convert.ToDouble(Console.ReadLine()) * percVal;
		//Calculo do vencimento
		Console.WriteLine("O valor da retribuição mensal é de: {0}", vencBase + vencCom + vencPerc);		
	}
}