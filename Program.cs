Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
string frase = $"Média arimética de 3 números.\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(65);
}
frase = "Digite o primeiro número: ";
for (int i = 0; i < frase.Length; i++)
{
    if (i < frase.Length-1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(frase[i]);
    Thread.Sleep(65);
    }
    else
    {        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(frase[i]);
    Thread.Sleep(65);      
    }
}
double primeiro = Convert.ToDouble(Console.ReadLine());
frase = $"Digite o segundo número: ";
for (int i = 0; i < frase.Length; i++)
{
    if (i < frase.Length-1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(frase[i]);
    Thread.Sleep(65);
    }
    else
    {        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(frase[i]);
    Thread.Sleep(65);      
    }
}
double segundo = Convert.ToDouble(Console.ReadLine());
frase = "Digite o terceiro número: ";
for (int i = 0; i < frase.Length; i++)
{
      if (i < frase.Length-1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(frase[i]);
    Thread.Sleep(65);
    }
    else
    {        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(frase[i]);
    Thread.Sleep(65);      
    }
}
double terceiro = Convert.ToDouble(Console.ReadLine());
double media = (primeiro+segundo+terceiro)/3;
Console.WriteLine("");
frase = $"Sua média é: {media:N1}\n";
for (int i = 0; i < frase.Length; i++)
{
       if (i < frase.Length-4)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(frase[i]);
    Thread.Sleep(65);
    }
    else
    {        
        Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(frase[i]);
    Thread.Sleep(65);      
    }
}
Console.ResetColor();
