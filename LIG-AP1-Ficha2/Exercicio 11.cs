//Exercicio 11. (C2E22) Escreva um programa que faca uso de operadores prefixos e posfixos.

using System;
class program
{
    static void Main(string[] args)
    {
        double valA, valB, valC, valD;
        valB = valD = 10;
        Console.WriteLine("Insira um valor: ");
        valA = valC = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Valor valA: {0} ", valA);
        Console.WriteLine("Valor valB: {0} ", valB);
        Console.WriteLine("Valor valC: {0} ", valC);
        Console.WriteLine("Valor valD: {0} ", valD);
        Console.WriteLine("Utilizacao de prefixos");
        Console.WriteLine("A executar a operacao: valB = ++valA");
        Console.WriteLine("Ao valor valA é atribuido o valor de valA + 1, posteriormente ao valor de valB é atribuido valor de valA");
        valB = ++valA;
        Console.WriteLine("Valor valA: {0} ", valA);
        Console.WriteLine("Valor valB: {0} ", valB);
        Console.WriteLine("Utilizacao de posfixos");
        Console.WriteLine("A executar a operacao: valD = valC++");
        Console.WriteLine("Ao valor valD é atribuido o valor de valC, posteriormente ao valor de valC é atribuido o resultado de valC +1");
        valD = valC++;
        Console.WriteLine("Valor valC: {0} ", valC);
        Console.WriteLine("Valor valD: {0} ", valD);
    }
}