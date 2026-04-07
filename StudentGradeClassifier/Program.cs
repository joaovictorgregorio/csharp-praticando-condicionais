Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("                     CLASSIFICAÇÃO NOTA DO ALUNO");
Console.ResetColor();
Console.WriteLine();

Console.Write("  Digite a nota final do aluno: ");
int studentGrade = int.Parse(Console.ReadLine()!);

if (studentGrade < 0 || studentGrade > 10)
    Console.WriteLine(" \n  Nota inválida. Tente novamente!");
else if (studentGrade >= 9)
    Console.WriteLine(" \n  O aluno recebeu a nota A.");
else if (studentGrade >= 7 && studentGrade <= 9)
    Console.WriteLine(" \n  O aluno recebeu a nota B.");
else if (studentGrade >= 5 && studentGrade < 7)
    Console.WriteLine(" \n  O aluno recebeu a nota C.");
else
    Console.WriteLine(" \n  O aluno recebeu a nota D.");