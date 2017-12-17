/*Exercicio 19. Escrever um programa que peça o valor da temperatura do dia e o classifique de acordo com a tabela seguinte:
Tabela disponivel no PDF*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int diaInput;
        Console.WriteLine("Introduza por favor a temperatura do dia: ");
        diaInput = Convert.ToInt32(Console.ReadLine());
        if (diaInput > 0 && diaInput < 4)
            Console.WriteLine("Gelado");
        else if (diaInput > 5 && diaInput < 6)
            Console.WriteLine("Muito");
        else if (diaInput == 7)
            Console.WriteLine("Frio");
        else if (diaInput > 8 && diaInput < 12)
            Console.WriteLine("Fresco");
        else if (diaInput > 13 && diaInput < 17)
            Console.WriteLine("Ameno");
        else if (diaInput > 18 && diaInput < 23)
            Console.WriteLine("Quente");
        else if (diaInput > 24 && diaInput < 45)
            Console.WriteLine("Muito Quente");
        else
            Console.WriteLine("Informação introduzida inválida");
    }
}