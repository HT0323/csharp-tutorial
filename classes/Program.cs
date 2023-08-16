// See https://aka.ms/new-console-template for more information
using Classes;

var account = new BankAccount("Tarou", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);
//var account1 = new BankAccount("Hanako", 4000);
//Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance.");


//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}
Console.WriteLine(account.GetAccountHistory());
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}