// See https://aka.ms/new-console-template for more information
int total = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        total += i;
    }
}
Console.WriteLine(total);

// ExploreLoops();
// ExploreIf();

void ExploreLoops()
{
    int counter = 0;
    do
    {
        Console.WriteLine($"Hello World Thr counter is {counter}");
        counter++;
    } while (counter < 10);

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Hello World Thr index is {i}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}
void ExploreIf()
{
    int a = 4;
    int b = 4;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is grater than 10.");
    }
    else
    {
        Console.WriteLine("The answer is not grater than 10.");
    }

    int c = 4;
    if ((a + b + c > 10) && (a == b))
    {
        Console.WriteLine("The answer is grater than 10.");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not grater than 10.");
        Console.WriteLine("Or the first number is equal to the second");
    }

    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is grater than 10.");
        Console.WriteLine("Or the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not grater than 10.");
        Console.WriteLine("And the first number is equal to the second");
    }
}
