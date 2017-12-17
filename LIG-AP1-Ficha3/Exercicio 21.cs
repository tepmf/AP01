/*Exercicio 21. Um posto vende combustíveis com a seguinte tabela de descontos:

Combustível litros Desconto p/l
Gasóleo até 20 3%
Gasóleo acima de 20 5%
Gasolina até 20 4%
Gasolina acima de 20 6%

Escreva um programa que leia o número de litros vendidos, o tipo de combustível (codificado da seguinte forma: 1-gasóleo, 2-gasolina), que calcule e mostre no ecrã o valor a ser pago pelo cliente sabendo-se que o preço do litro do gasóleo é 1,17Euros o da gasolina é de 1,42Euros.
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double tipoComb, litrVend, valoPag;
        valoPag = 0;
        Console.WriteLine("Insira o número de litros vendidos: ");
        litrVend = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insira tipo de combustível:");
        Console.WriteLine("Para Gasóleo inserir \"1\"");
        Console.WriteLine("Para Gasolina inserir \"2\"");
        tipoComb = Convert.ToSingle(Console.ReadLine());
        if (tipoComb == 1)
            valoPag = (litrVend < 20) ? (litrVend * 1.17) * 0.97 : (litrVend * 1.17) * 0.95;
        if (tipoComb == 2)
            valoPag = (litrVend < 20) ? (litrVend * 1.42) * 0.96 : (litrVend * 1.42) * 0.94;
        Console.WriteLine("Valor a pagar é de {0:F2}", valoPag);
    }
}