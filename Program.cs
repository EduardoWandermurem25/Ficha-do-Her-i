
Console.WriteLine("==========================");
Console.WriteLine("      FICHA DO HERÓI");
Console.WriteLine("==========================");

Console.Write("\nDigite o nome do personagem: ");
string nome = Console.ReadLine() ?? "";

Console.Write("Digite a classe do personagem: ");
string classe = Console.ReadLine() ?? "";

int vida = 100;
int moeda = 20;
int nivel = 1;

Console.WriteLine("\n====== FICHA DO HERÓI ======");

Console.WriteLine($"Nome:   {nome}");
Console.WriteLine($"Classe: {classe}");
Console.WriteLine($"Vida:   {vida}");
Console.WriteLine($"Moedas: {moeda}");
Console.WriteLine($"Nível:  {nivel}");

Console.WriteLine("============================");
Console.WriteLine("   Sua aventura começa!");
