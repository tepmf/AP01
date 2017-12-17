//Exercicio 7. Desenvolva um programa que leia três valores inteiros e determine se estes podem corresponder aos lados de um triângulo. Alêm disso, se os valores corresponderem aos lados de um triângulo, este deve ser classícado como equilátero, isósceles ou escaleno. Nota: um triângulo é uma forma geométrica composta de três lados e o valor de cada lado deve ser menor que a soma dos valores dos outros dois lados.

using System;
class Program
{
    static void Main(string[] args)
    {
        double lado1, lado2, lado3;
        Console.WriteLine("Insira a dimensão do primeiro lado: ");
        lado1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a dimensão do segundo lado: ");
        lado2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a dimensão do terceiro lado: ");
        lado3 = Convert.ToDouble(Console.ReadLine());
        if (lado1 > (lado2 + lado3) || lado2 > (lado1 + lado3) || lado3 > (lado1 + lado2))
            Console.WriteLine("As dimensões introduzidas não correspondem a um triângulo!");
        else if (lado1 == lado2 && lado1 == lado3)
            Console.WriteLine("Triângulo Equilátero!");
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            Console.WriteLine("Triângulo Isósceles!");
        else
            Console.WriteLine("Triângulo Escaleno!");
    }
}