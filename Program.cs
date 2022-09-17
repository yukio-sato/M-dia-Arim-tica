Console.ForegroundColor = ConsoleColor.DarkRed;
for (int i = 0; i < 28; i++)
{
    Console.Write("Média arimética de 3 números"[i]);
    Thread.Sleep(65);
}
Console.WriteLine("\n");
Console.ForegroundColor = ConsoleColor.Gray;
for (int i = 0; i < 26; i++)
{
    Console.Write("Digite o primeiro número: "[i]);
    Thread.Sleep(65);
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
double primeiro = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Gray;
for (int i = 0; i < 26; i++)
{
    Console.Write("Digite o segundo número:  "[i]);
    Thread.Sleep(65);
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
double segundo = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Gray;
for (int i = 0; i < 26; i++)
{
    Console.Write("Digite o terceiro número: "[i]);
    Thread.Sleep(65);
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
double terceiro = Convert.ToDouble(Console.ReadLine());
double media = (primeiro+segundo+terceiro)/3;
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Gray;
for (int i = 0; i < 13; i++)
{
    Console.Write($"Sua média é: "[i]);
    Thread.Sleep(65);
}
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"{media:N1}");
Console.WriteLine("");
Console.ResetColor();
