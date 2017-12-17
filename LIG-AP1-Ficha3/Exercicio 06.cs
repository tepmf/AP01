//Exercicio 6. Determinar em função das notas obtidas nas frequências se o aluno é ou não aprovado à UC de algoritmos e programação, sabendo que são realizadas duas frequências, cada uma com um peso de 10 valores na nota Final e nota mínima de 8 valores.

using System;
class Program
{
    static void Main(string[] args)
    {
        double priFreq, secFreq;
        Console.WriteLine("Insira a nota da primeira frequência: ");
        priFreq = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a nota da segunda frequência: ");
        secFreq = Convert.ToDouble(Console.ReadLine());
        if (priFreq > 8 && secFreq > 8)
            Console.WriteLine("Aluno aprovado com {0}", (priFreq + secFreq) / 2);

        else
            Console.WriteLine("Aluno reprovado");
    }
}