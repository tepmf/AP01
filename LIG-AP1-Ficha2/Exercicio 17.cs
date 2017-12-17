//Exercicion 17. (C3E5) Escreva um programa que converta dolares americanos para euros.

using System;
class Program
{
    static void Main()
    {
        double valor, dolar, euro;
        Console.WriteLine("Insira o valor em dólares");
        dolar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a o valor actual do euro(no formato x,xxx - Por exemplo 1 Dolar = 0,8756 Euros)");
        euro = Convert.ToDouble(Console.ReadLine());
        valor = dolar * euro;
        Console.WriteLine("Valor em Euros: {0}", valor);
    }
}