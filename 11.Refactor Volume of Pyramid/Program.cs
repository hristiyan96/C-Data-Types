// See https://aka.ms/new-console-template for more information

double volume = 0;
Console.Write("Length: ");
double length = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());
volume = (length * width * height) / 3;
Console.Write($"Pyramid Volume: {volume:f2}");
