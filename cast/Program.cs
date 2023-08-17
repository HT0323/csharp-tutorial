// See https://aka.ms/new-console-template for more information
//int first = 2;
//string second = "4";
//string result = first + second;
//Console.WriteLine(result);

//int myInt = 3;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = myInt;
//Console.WriteLine($"decimal: {myDecimal}");

//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float : {myFloat}");

//int first = 5;
//int second = 7;
//string message = first.ToString() + second.ToString();
//Console.WriteLine(message);

//string first = "5";
//string second = "7";
//int sum = int.Parse(first) + int.Parse(second);
//Console.WriteLine(sum);

//string first = "5";
//string second = "7";
//int sum = Convert.ToInt32(first) + Convert.ToInt32(second);
//Console.WriteLine(sum);

//int value = (int)1.5m;
//Console.WriteLine(value);

//int value2 = Convert.ToInt32(1.5m);
//Console.WriteLine(value2);

//string value = "102";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement");
//}

//Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//double total = 0.0;
//string message = "";
//double result = 0.0;

//foreach (var value in values)
//{

//    if (double.TryParse(value, out result))
//    {
//        total += result;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine(total);
//Console.WriteLine(message);

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");