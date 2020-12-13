using System;

namespace study02
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("KHJcode", 1000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
      Console.WriteLine(account.Balance);
      account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
      Console.WriteLine(account.Balance);

      try
      {
        var invalidAccount = new BankAccount("invaild", -55);
      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine("Exception caught creating account with negative balance");
        Console.WriteLine(e.ToString());
      }

      try
      {
        account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
      }

      Console.WriteLine(account.GetAccountHistory());
    }
  }
}
