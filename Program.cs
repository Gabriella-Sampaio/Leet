Console.Clear();

Console.OutputEncoding = System.Text.Encoding.UTF8;

string texto;
string textoLeet;

Console.WriteLine
("       *** BEM VINDO ***       "); Thread.Sleep(500);
Console.WriteLine
(@"
Aqui você converte seus textos 
   em linguagem Leet Speak"); Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine("Vamos começar!"); Thread.Sleep(1000);
Console.WriteLine("Digite seu texto: ");
texto = Console.ReadLine()!;

textoLeet= texto
    .Replace("A", "4")
    .Replace("a", "4")
    .Replace("á", "4")
    .Replace("E", "3")
    .Replace("e", "3")
    .Replace("é", "3") //acento??
    .Replace("I", "1")
    .Replace("i", "1")
    .Replace("L", "1")
    .Replace("l", "1")
    .Replace("O", "0")
    .Replace("o", "0")
    .Replace("T", "7")
    .Replace("t", "7")
    .Replace("S", "5")
    .Replace("s", "5");

Console.WriteLine($"\nResultado: {textoLeet}");
