//Exercicio 16. Construa o algoritmo de um programa que calcule o valor total a pagar por determinado artigo, sabendo o tipo de artigo e o seu preço sem IVA. Suponha que a taxa de IVA é de 5% para os bens essenciais, 30% para os produtos de luxo e 20% para os restantes.
using System;
class Program
{
    static void Main(string[] args)
    {
        byte input;
        double preco;
        Console.WriteLine("Qual o preço base?");
        preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o tipo de bem?");
        Console.WriteLine("Tipo 1 - (Bem essencial)");
        Console.WriteLine("Tipo 2 - (Bem normal)");
        Console.WriteLine("Tipo 3 - (Bem de Luxo)");
        input = Convert.ToByte(Console.ReadLine());
        if (input == 1)
            Console.WriteLine("Preço final: {0}", preco * 1.05);
        else if (input == 2)
            Console.WriteLine("Preço final: {0}", preco * 1.20);
        else if (input == 3)
            Console.WriteLine("Preço final: {0}", preco * 1.30);
        else
            Console.WriteLine("Informação introduzida invalida");
    }
}