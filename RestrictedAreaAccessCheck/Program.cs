Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("                     ACESSO ÁREA RESTRITA");
Console.ResetColor();
Console.WriteLine();

Console.Write("  Digite a senha: ");
int password = int.Parse(Console.ReadLine()!);

Console.Write("  Digite o nível de acesso: ");
int acessLevel = int.Parse(Console.ReadLine()!);

if (password == 42 && acessLevel >= 5)
    Console.WriteLine(" \n  Acesso liberado");
else
    Console.WriteLine(" \n  Acesso negado");