Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                     SALDO DA CONTA");
Console.ResetColor();
Console.WriteLine();


Console.Write("  Digite o saldo: ");
double accountBalance = double.Parse(Console.ReadLine()!);

if (accountBalance < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("  O saldo está negativo.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  O saldo está positivo.");
    Console.ResetColor();
}
    