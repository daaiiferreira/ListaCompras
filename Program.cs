// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
//Crie um programa que permita ao usuário digitar uma lista de itens.
//Ao final o programa deve mostrar a lista de itens completa. Não deve ser permitido adicionar
//o mesmo item duas vezes.

Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Black;

string[] itens = new string[10];
string maisitens;
 
Console.WriteLine("BEM VINDO A LISTA DE COMPRAS, NÃO INFARTA QUE TÁ TUDO CARO!!!");

do
{
    Console.WriteLine("Digite o ítem que deseja adicionar a lista?");
    string item = Console.ReadLine();
    
    int posicao = 0;
    
    bool encontrou = false;

    for (int i = 0; i < itens.Length; i++)
    {
        if (itens[i].ToUpper() == item.ToUpper())
        {
            posicao = i;
            encontrou = true;
           
        }
        else
            Console.WriteLine("Produto ja existe na lista");
    }
    if (encontrou)
        itens[0] = item;


    Console.WriteLine("Deseja pesquisar outro? (s/n)");
    maisitens = Console.ReadLine();
} while (maisitens != "n");
for (int i = 0; i < itens.Length; i++)
{
    Console.WriteLine($"Pessoas maiores de idade");
    Console.WriteLine($"{itens[i]}.");
}







