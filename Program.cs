Console.WriteLine("-----Ficha do Herói-----");
Console.WriteLine("\n Digite o nome do seu Personagem:");
string nome = Console.ReadLine() ?? "";

int vida = 100;
int moeda = 20;
int nivel = 1;

Console.WriteLine("\n Digite a classe do seu Personagem:");
string classe = Console.ReadLine() ?? "";

Console.WriteLine($"\n---Ficha do Personagem---\n Nome: {nome}\n Vida: {vida}\n Moeda: {moeda}\n Nível: {nivel}\n Classe: {classe}");