// See https://aka.ms/new-console-template for more information
char a = Console.ReadLine()[0];
if(char.IsUpper(a))
{
    Console.WriteLine("upper-case");
}
else if(char.IsLower(a))
{
    Console.WriteLine("lower-case");
}
else
{
    Console.WriteLine("not a letter");
}
