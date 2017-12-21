//Exercicio 17. Escreva um programa que escreva no monitor os múltiplos de 5 não múltiplos de 3, compreendidos entre dois valores limite introduzidos pelo utilizador. O programa deve certificar-se que os limites indicados são positivos e que o limite inferior é realmente menor do que o limite superior.

using System;
class Program
{
    static void Main(string[] args)
    {
        bool val = false;
        int inpum, inpdo;
        do
        {
            Console.WriteLine("Valor minimo: ");
            inpum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor maximo: ");
            inpdo = Convert.ToInt32(Console.ReadLine());
            if (inpum > 0 && inpum < inpdo)
                val = true;
            else
            {
                Console.WriteLine("Valores inválidos!");
                Console.WriteLine("introduza novos valores");
            }

        }
        while (val == false);
        while (inpum < inpdo)
        {
            if (inpum % 5 == 0 && inpum % 3 != 0)
                Console.WriteLine("Multiplo de 5 e não de 3: {0}", inpum);
            inpum++;
        }

    }
}
