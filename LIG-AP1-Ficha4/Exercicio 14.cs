//Exercicio 14. Qual é o menor número inteiro positivo, tal que, se retirarmos o algarismo das unidades e o colocarmos do lado esquerdo, obtemos um número 4 vezes maior. Escreva um programa que resolva o problema proposto.

using System;
class Program
{
    static void Main(string[] args)
    {
        int numero, auxiliar1, auxiliar2;
        numero = 10;
        auxiliar1 = auxiliar2 = 0;
        while (auxiliar2 < 1)
        {
            auxiliar1 = numero % 10 * 10 + (numero /10);
            if (auxiliar1 > numero * 4)
                auxiliar2++;
            else
                numero++;
        }
        Console.WriteLine("O menor número: {0}", numero);
    }
}