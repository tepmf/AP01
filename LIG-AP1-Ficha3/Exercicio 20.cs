/*Exercicio 20. O índice de massa corporal (IMC) obtém-se dividindo o peso pelo quadrado da altura. Por exemplo, uma pessoa que tenha 71 quilos e 1,67 metros de altura, tem 25,4 de IMC. A Organização Mundial de Saúde (OMS) definiu os seguintes escalões:

Escalão IMC Descrição
1 IMC < 19,99 Peso insuficiente
2 20 <= IMC >= 24,99 Peso normal
3 25 <= IMC >= 29,99 Pré-obesidade
4 30 <= IMC >= 34,99 Obesidade
5 IMC >= 35 Grande obsesidade
Implemente um programa que receba a altura e o peso de um indivíduo e indique o escalão em que este se encontra.
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        float altu, peso, imc;
        Console.WriteLine("Insira a altura em metros:");
        altu = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insira o peso em kilogramas");
        peso = Convert.ToSingle(Console.ReadLine());
        imc = peso / (altu * altu);
        if (imc < 19.99)
            Console.WriteLine("Escalão: Insuficiente");
        else if (20 >= imc & imc <= 24.99)
            Console.WriteLine("Escalão: Normal");
        else if (25 >= imc & imc <= 29.99)
            Console.WriteLine("Escalão: PreObesidade");
        else if (30 >= imc & imc <= 34.99)
        Console.WriteLine("Escalão: Obesidade");
        else
            Console.WriteLine("Escalão: Grande Obesidade");
    }
}