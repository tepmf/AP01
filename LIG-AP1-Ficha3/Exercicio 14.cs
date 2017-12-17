/*Exercicio 14. Escreva um programa que faça 5 perguntas a uma pessoa sobre um crime.
As perguntas são:
- Telefonou para a vítima?
- Esteve no local do crime?
- Mora perto da vítima?
- Devia à vítima?
- Jà trabalhou com a vítima?
O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ele será classificado como "Inocente".
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int resposta;
        Console.WriteLine("Telefonou para a vitima? Sim - Prima 1, caso contrário prima 0");
        resposta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Esteve no local do crime? Sim - Prima 1, caso contrário prima 0");
        resposta += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mora perto da vítima? Sim - Prima 1, caso contrário prima 0");
        resposta += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Devia à vítima? Sim - Prima 1, caso contrário prima 0");
        resposta += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Jà trabalhou com a vítima? Sim - Prima 1, caso contrário prima 0");
        resposta += Convert.ToInt32(Console.ReadLine());
        if (resposta == 0)
            Console.WriteLine("Inocente");
        else if (resposta > 0 && resposta < 3)
            Console.WriteLine("Suspeita");
        else if (resposta > 2 && resposta < 5)
            Console.WriteLine("Cúmplice");
        else
            Console.WriteLine("Assassino");
    }

}

