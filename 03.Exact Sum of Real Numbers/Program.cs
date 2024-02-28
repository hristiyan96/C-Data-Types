// See https://aka.ms/new-console-template for more information
decimal n = decimal.Parse(Console.ReadLine());
decimal sum = 0;
for (int i = 0; i < n; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);


