﻿using System;

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


      var giftCard = new GiftCardAccount("gift card", 100, 50);
      giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
      giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
      giftCard.PerformMonthEndTransactions();
      giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
      Console.WriteLine(giftCard.GetAccountHistory());
      
      var savings = new InterestEarningAccount("savings account", 10000);
      savings.MakeDeposit(750, DateTime.Now, "save some money");
      savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
      savings.MakeDeposit(250, DateTime.Now, "Needed to pay monthly bills");
      savings.PerformMonthEndTransactions();
      Console.WriteLine(savings.GetAccountHistory());

    }
  }
}
