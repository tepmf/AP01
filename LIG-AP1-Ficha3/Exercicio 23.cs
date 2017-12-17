//Exercicio 23. (C4Ex15) Elabore um programa com afixe o seguinte conjunto de opções: 1. Levantamento; 2. Depósito; 3. Pagamento de serviços; 4. Fim. O programa deve ler a opçao escolhida pelo utilizador e indicar o procedimento respetivo.

using System;
class Program
{
    static void Main(string[] args)
    {
        int optInput;
        Console.WriteLine("Introduza uma opção: ");
        Console.WriteLine("Opção \"1\" Levantamento");		
        Console.WriteLine("Opção \"2\" Depósito");		
        Console.WriteLine("Opção \"3\" Pagamento de serviços");		
        Console.WriteLine("Opção \"4\" Fim");			
        optInput = Convert.ToInt32(Console.ReadLine());
        switch (optInput)
		{
			case 1:
				Console.WriteLine("Indique o valor a levantar");
                break;
			case 2:
				Console.WriteLine("Indique o valor a depositar");
                break;
            case 3:
				Console.WriteLine("Introduza o código do serviço");
                break;
            case 4:
				Console.WriteLine("Retire o cartão");
                break;
            default:
				Console.WriteLine("Informação introduzida inválida");
                break;
        }
    }
}