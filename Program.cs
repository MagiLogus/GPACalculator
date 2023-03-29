// Crie um programa para calcular a media aritmética 

// Algoritimo 
// Entrada: as 5 notas
// Proscessamento: somar as 5 notas e dividir por 5

//Entrada 
Console.BackgroundColor =ConsoleColor.Black;

Console.WriteLine(@$"
--------------------------------
|       Programa para          |
|     calcular sua media       |
|         Aritmética           |
--------------------------------
");

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo {nome} !");

Console.WriteLine($"Digite sua nota 1: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota 2: ");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota 3: ");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota 4: ");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota 5: ");
float nota5 = float.Parse(Console.ReadLine());

// Processamento 
float media = (nota1+nota2+nota3+nota4+nota5)/5;

// Saida
Console.WriteLine($"{nome} sua media é : {media} pontos. ");

Console.WriteLine($"Obrigado por utilizar nosso sistema. ");