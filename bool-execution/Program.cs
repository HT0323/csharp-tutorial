// See https://aka.ms/new-console-template for more information
//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);
//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangrm = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangrm.Contains("fox"));
//Console.WriteLine(pangrm.Contains("cow"));

//Console.WriteLine(!pangrm.Contains("fox"));
//Console.WriteLine(!pangrm.Contains("cow"));

//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

//Random coin = new Random();
//int filp = coin.Next(0, 2);
//Console.WriteLine(filp == 0 ? "heads" : "tails");

string permission = "Manaer";
int level = 5;

if (permission.Contains("Admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Admin") && level <= 55)
    Console.WriteLine("Welcome, Admin user.");
else if (permission.Contains("Manager") && level >= 20)
    Console.WriteLine("Contact an Admin for access.");
else if (permission.Contains("Manager") && level < 20)
    Console.WriteLine("You do not have sufficient privileges.");
else if (!permission.Contains("Admin") || !permission.Contains("Manager"))
    Console.WriteLine("You do not have sufficient privileges.");