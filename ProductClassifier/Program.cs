Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("                     CLASSIFICAÇÃO DE PRODUTOS");
Console.ResetColor();
Console.WriteLine();


Console.Write("  Digite o código do produto (1 ou 2): ");
sbyte productCode = sbyte.Parse(Console.ReadLine()!);

if (productCode == 1)
{
    Console.WriteLine(" \n  Perecível");
}
else if (productCode == 2)
{
    Console.WriteLine(" \n  Não perecível");
}
else
{
    Console.WriteLine(" \n  Código digitado inválido!");
}
    