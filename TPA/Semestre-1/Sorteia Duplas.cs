// See https://aka.ms/new-console-template for more information
string vFrase, x;
int i, numsort;
Random numAleatorio = new Random();

Console.WriteLine("\n--------------------------------------");
Console.WriteLine("Bem vindo ao Sorteia Duplas");
Console.WriteLine("\n--------------------------------------\n\n");

Console.WriteLine("Quantas duplas deseja digitar: ");
while (!int.TryParse(Console.ReadLine(), out i) || i <= 0)
{
    Console.WriteLine("Número inválido. Digite novamente: ");
}
string[,] duplas = new string[i, 2];
string[,] sort = new string[i, 2];


Console.WriteLine("Digite os nomes: ");
for(int l=0; l<i; l++)
{
    for(int c=0; c<2; c++)
    {
        Console.WriteLine($"Digite o {l+1}° nome: ");
        vFrase = Console.ReadLine();
        duplas[l,c] += vFrase;
    }
}
for(int l=0; l<i; i++)
{
    for(int c=0; c<2; c++)
    {
        numsort = numAleatorio.Next(l,c);
        string temp = duplas[l,c];
        sort[l, c] = duplas[numsort,c];   
 
    }
}

for (int l = 0; l < i; l++)
{
    for (int c = 0; c < 2; c++)
    {
        Console.Write($"Dupla: 1° nome - {sort[l, c]}");
    }
}
