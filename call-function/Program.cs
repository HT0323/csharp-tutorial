// See https://aka.ms/new-console-template for more information
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int number = 7;
string text = "seven";

Console.WriteLine(text);
Console.WriteLine();
Console.Write(number);

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);

int firstValue = 500;
int secondValue = 600;
int largeValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largeValue);