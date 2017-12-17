//Exercicio 9. Escreva um programa que apresente os numeros anteriores em percentagem.
//Exercicio 8. (C2E16) Escreva um programa que apresente os seguintes numeros arredondados a duas casas decimais: 4,78905; 4,7; 5,8954; 5.
using System;
class program
{
    static void Main(string[] args)
    {
        double a, b, c, d;
        a = 4.78905;
        b = 4.7;
        c = 5.8954;
        d = 5;
        Console.WriteLine("{0:P}", Math.Round(a, 2) /100 );
        Console.WriteLine("{0:P}", Math.Round(b, 2) /100 );
        Console.WriteLine("{0:P}", Math.Round(c, 2) /100 );
        Console.WriteLine("{0:P}", Math.Round(d, 2) /100 );
    }
}

/*V2
using System;
class program
{
    static void Main(string[] args)
    {
        double a, b, c, d;
        a = 4.78905;
        b = 4.7;
        c = 5.8954;
        d = 5;
        Console.WriteLine("{0:p}", a);
        Console.WriteLine("{0:p}", b);
        Console.WriteLine("{0:p}", c);
        Console.WriteLine("{0:p}", d);
    }
}
/*