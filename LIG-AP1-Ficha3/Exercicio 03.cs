//Exercicio 3. (C4E10) Escreva um programa que efetue a leitura de três valores inteiros e os escreva no monitor por ordem crescente.
using System;
class Program
{
    static void Main(string[] args)
    {
        int val1, val2, val3, valAux;
        valAux = 0;
        Console.WriteLine("Insira o primeiro valor a considerar: ");
        val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor a considerar: ");
        val2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o terceiro valor a considerar: ");
        val3 = Convert.ToInt32(Console.ReadLine());
        while (valAux < 3)
        {
            if (val1 < val2 && val1 < val3)
            {
                Console.WriteLine("{0}", val1);
                val1 = val1 + val2 + val3;
                valAux++;
            }
            else if (val2 < val1 && val2 < val3)
            {
                Console.WriteLine("{0}", val2);
                val2 = val2 + val1 + val3;
                valAux++;
            }
            else
            {
                Console.WriteLine("{0}", val3);
                val3 = val2 + val1 + val3;
                valAux++;
            }
        } 
    }
}