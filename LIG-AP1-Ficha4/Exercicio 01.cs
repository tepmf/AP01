// 1. Escreva um programa que imprima no ecr~a os números de 1 a 20, um abaixo do outro.

using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 21; i++)
            Console.WriteLine(i);


    }
}

/*V2
using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 20)
        {
            i++;
            Console.WriteLine(i);
            
        }
    }
}

v3
using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        do
        {
            i++;
            Console.WriteLine(i);
        }
        while (i < 20);
    }
}
*/
