//Exercicion 18. (C3E6) Escreva um programa que converta a temperatura lida em graus Fahrenheit para graus Celsius. A formula de C = 5/9 * (f - 32).

using System;
class Program
{
    static void Main()
    {
        double fahrenheit, celsius, auxiliar1, auxiliar2, auxiliar3, auxiliar4, auxiliar5;
        auxiliar1 = 5;
        auxiliar2 = 9;
        Console.WriteLine("Insira o valor em Fahrenheit");
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        auxiliar3 = auxiliar1/auxiliar2;
        auxiliar4 = auxiliar3 * fahrenheit;
        auxiliar5 = auxiliar3 * 32;
        celsius = auxiliar4 - auxiliar5;
        Console.WriteLine("Valor em graus Celcius: {0}", celsius);
    }
}