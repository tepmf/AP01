//Exercicio 15 Escreva um programa que, por tentativas, adivinha um número que é gerado pelo computador. Em cada tentativa deve-lhe ser indicado se o número que introduziu é maior ou menor que o valor gerado. O programa termina quando acertar. No final indique o número de tentativas utilizadas. Sugestão: Comece por definir o intervalo de procura.

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int valMax, valMin, valGen, valInp, valTen;
        valTen = 0;
        Console.WriteLine("Insira o valor minimo: ");
        valMin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o valor máximo: ");
        valMax = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor maximo de {0} e minimo de {1}",valMin,valMax);
        valGen = rnd.Next(valMin, valMax);
        do
        {
            Console.WriteLine("Tente um valor: ");
            valInp = Convert.ToInt32(Console.ReadLine());
            valTen++;
            if (valGen > valInp)
                Console.WriteLine("O valor introduzido e menor... tente de novo");
            if (valGen < valInp)
                Console.WriteLine("O valor introduzido e maior... tende de novo");
        }
        while (valInp != valGen);
        Console.WriteLine("Acertou!");
        Console.WriteLine("Tentou {0} vezes", valTen);
    }
}