/*22. O Hipermercado Continente está com uma promoção de carnes:
Descrição Preço p/kg até 5kg Preço p/kg acima de 5kg
Febras 1,60e 1,80e
Alcatra 11,60e 12,80e
Picanha 15,60e 17,80e

Para atender a todos os clientes, cada cliente poderá levar apenas um dos tipos de carne da promoção, porém não há limites para a quantidade de carne por cliente. Se compra for feita com cartão continente o cliente receberberá ainda 5% de desconto sobre a compra. Escreva um programa que peça o tipo e a quantidade de carne comprada pelo utilizador e mostre no final as seguintes informações: tipo e quantidade de carne, preço total, valor do desconto e valor a pagar.

*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double pesoComp, precTota, valoDesc, valoPaga, variAuxi;
        string tipoCarn;
        Console.WriteLine("Insira o tipo de carne escolhido:");
        Console.WriteLine("Para Febras, insira \"Febras\"");
        Console.WriteLine("Para Alcatra, insira \"Alcatra\"");
        Console.WriteLine("Para Picanha, insira \"Picanha\"");
        tipoCarn = Console.ReadLine();
        Console.WriteLine("Insira a quantidade comprada em kilogramas");
        pesoComp = Convert.ToSingle(Console.ReadLine());
        variAuxi = pesoComp - 5;
        precTota = valoDesc = valoPaga = 0;
        switch (tipoCarn)
        {
            case "Febras":
                if (pesoComp < 5)
                {
                    precTota = pesoComp * 1.60;
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                else
                {

                    precTota = (5 * 1.60) + (variAuxi * 1.80);
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                break;
            case "Alcatra":
                if (pesoComp < 5)
                {
                    precTota = pesoComp * 11.60;
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                else
                {
                    precTota = (5 * 11.60) + (variAuxi * 12.80);
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                break;
            case "Picanha":
                if (pesoComp < 5)
                {
                    precTota = pesoComp * 15.60;
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                else
                {
                    precTota = (5 * 15.60) + (variAuxi * 17.80);
                    valoDesc = precTota * 0.05;
                    valoPaga = precTota * 0.95;
                }
                break;
            default:
                {
                    Console.WriteLine("Dados introduzidos inválidos");
                    break;
                }
        }
        Console.WriteLine("Tipo de Carne {0}", tipoCarn);
        Console.WriteLine("Quantidade de Carne {0}Kg", pesoComp);
        Console.WriteLine("Preço Total {0}", precTota);
        Console.WriteLine("Valor do desconto {0}", valoDesc);
        Console.WriteLine("Valor a pagar {0}", valoPaga);
    }
}