// See https://aka.ms/new-console-template for more information
//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');
//openingPosition++;

////Console.WriteLine(openingPosition);
////Console.WriteLine(closingPosition);

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//string message = "What is the value <span>between the tags</span>?";

//const string openSpan = "<span>";
//const string closeSpan = "</span>";

//int openingPosition = message.IndexOf(openSpan);
//int closingPosition = message.IndexOf(closeSpan);


//openingPosition += openSpan.Length;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');

//openingPosition++;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition++;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    message = message.Substring(closingPosition + 1);
//}

//string message = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {message}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 6;
//int openingPosition = message.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

//openingPosition = message.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

//string data = "12345John Smith          5000  3  ";
//string updatedData = data.Remove(5, 20);
//Console.WriteLine(updatedData);

//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);

output = input.Replace("<div>", "").Replace("</div>", "").Replace("&trade;", "&reg;");


Console.WriteLine(quantity);
Console.WriteLine(output);