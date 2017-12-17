//Exercicio 17. (C4E14) Crie um programa que implemente uma máquina calculadora. Construa um algoritmo para ler dois valores e selecione uma das seguintes operações a ser executadas (1.Adição, 2. Subtracção, 3. Divisão, 4. Multiplicação). O algoritmo deve calcular e escrever o resultado dessa operação sobre os dois valores lidos.
using System;
class Program
{
    static void Main(string[] args)
    {
        char tipoOper;
        double primValor, seguValor;
        Console.WriteLine("Qual o primeiro valor?");
        primValor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o segundo valor?");
        seguValor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o tipo de operacao?");
        Console.WriteLine("Tipo 1 - (Soma) - Introduzir - \"+\" ");
        Console.WriteLine("Tipo 2 - (Subtracção) - Introduzir - \"-\" ");
        Console.WriteLine("Tipo 3 - (Divisão) - Introduzir - \"/\" ");
        Console.WriteLine("Tipo 4 - (Multilicação) - Introduzir - \"*\" ");
        tipoOper = Convert.ToChar(Console.ReadLine());
        if (tipoOper.Equals('+'))
            Console.WriteLine("Resultado final: {0}", primValor + seguValor);
        else if (tipoOper.Equals('-'))
            Console.WriteLine("Resultado final: {0}", primValor - seguValor);
        else if (tipoOper.Equals('/'))
            Console.WriteLine("Resultado final: {0}", primValor / seguValor);
        else if (tipoOper.Equals('*'))
            Console.WriteLine("Resultado final: {0}", primValor * seguValor);
        else
            Console.WriteLine("Informação introduzida inválida");
    }
}