using System;

namespace study02
{
  public class Transaction
  {
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amout, DateTime date, string note)
    {
      this.Amount = amout;
      this.Date = date;
      this.Notes = note;
    }
  }
}
