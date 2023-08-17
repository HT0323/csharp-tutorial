using System.Text.RegularExpressions;

// See https://aka.ms/new-console-template for more information
//Random random = new Random();
//int current = 0;

//do
//{
//    current = random.Next(1, 11);
//    if (current >= 8) continue;
//    Console.WriteLine(current);
//} while (current != 7);

//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

//Random random = new Random();
//int heroHp = 10;
//int monsterHp = 10;
//int damge = 0;

//do
//{
//    damge = random.Next(1, 11);
//    monsterHp -= damge;
//    Console.WriteLine($"Monster was damaged and lost {damge} health and now has {monsterHp} health.");
//    if (monsterHp <= 0)
//    {
//        Console.WriteLine("Hero wins!");
//        break;
//    }

//    damge = random.Next(1, 11);
//    heroHp -= damge;
//    Console.WriteLine($"Hero was damaged and lost {damge} health and now has {heroHp} health.");
//    if (heroHp <= 0)
//    {
//        Console.WriteLine("Monster wins!");
//        break;
//    }
//} while (true);

//Console.WriteLine("Enter an integer value between 5 and 10");
//do
//{
//    var intputValue = Console.ReadLine();
//    if (Regex.IsMatch(intputValue, @"^\d+$"))
//    {
//        int convertValue = Convert.ToInt32(intputValue);
//        if (convertValue >= 5 && convertValue <= 10)
//        {
//            Console.WriteLine($"Your input value ({intputValue}) has been accepted.");
//            break;
//        }
//        else
//        {
//            Console.WriteLine($"You entered {intputValue}. Please enter a number between 5 and 10.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Sorry, you entered an invalid number, please try again");
//    }
//} while (true);

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    var intputValue = Console.ReadLine();
    string modValue = intputValue.Trim().ToUpper();

    if (Regex.IsMatch(modValue, @"^ADMINISTRATOR|MANAGER|USER$"))
    {
        Console.WriteLine($"Your input value ({intputValue}) has been accepted.");
        break;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{intputValue}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (true);