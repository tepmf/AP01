// Exercicio 6. Altere o programa anterior para mostrar no final a soma dos numeros.
using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b,c ;
		c = 0;
        Console.WriteLine("Introduza o maior numero:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduza o menor numero:");
        b = Convert.ToInt32(Console.ReadLine());
        while (a > b +1 )
        {
            a -= 1;
            Console.WriteLine("A Imprimir {0}",a);
			c++;
        }
		Console.WriteLine("Sima dos numeros {0}",c);
    }
}
