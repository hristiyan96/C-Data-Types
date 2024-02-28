// See https://aka.ms/new-console-template for more information
int quantity = int.Parse(Console.ReadLine());
int sum = 0;
int that = 0;
bool IsSpecialNum = false;
for (int ch = 1; ch <= quantity; ch++)
{
    that = ch;
    while (ch > 0)
    {
        sum += ch % 10;
        ch = ch / 10;
    }
    IsSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", that, IsSpecialNum);
    sum = 0;
    ch = that;
}