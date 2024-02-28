// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());


for (int number = 1; number <= n; number++)
{
    bool isSpecial = IsSpecialNumber(number);
    Console.WriteLine($"{number} -> {isSpecial}");
}
static bool IsSpecialNumber(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum == 5 || sum == 7 || sum == 11;
}


