using System;

namespace study02
{
  public class LineOfCreditAccount : BankAccount
  {

    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
    {

    }

    protected override Transaction CheckWithdrawalLimit(bool isOverdrawn) =>
      isOverdrawn
      ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
      : default;

    public override void PerformMonthEndTransactions()
    {
      if (Balance > 500m)
      {
        var interest = Balance * 0.05m;
        MakeDeposit(interest, DateTime.Now, "apply monthly interest");
      }
    }
    
  }
}
