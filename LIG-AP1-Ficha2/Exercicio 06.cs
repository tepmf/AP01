/*Exercicio 6. (C2E8) Escreva um programa que apresente no ecra o resultado das operacoes
logicas:
4 == 5
4 != 6
4 > 5
4 < 5 E 6 > 10
40 < 50 OU 60 > 90
Nao (40 < 50 OU 60 > 90)
*/

using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", 4 == 5);
        Console.WriteLine("{0}", 4 != 6);
        Console.WriteLine("{0}", 4 > 5);
        Console.WriteLine("{0}", 4 < 5 && 6 > 10);
        Console.WriteLine("{0}", 40 < 50 || 60 > 90);
        Console.WriteLine("{0}", !(40 < 50 || 60 > 90));
    }
}