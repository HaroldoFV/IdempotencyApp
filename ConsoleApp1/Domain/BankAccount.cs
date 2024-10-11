namespace ConsoleApp1.Domain;

public class BankAccount
{
    public string Number { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string number, decimal initialBalance)
    {
        Number = number;
        Balance = initialBalance;
    }

    public void Debit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor a ser debitado deve ser maior que zero.", nameof(amount));

        if (Balance < amount)
            throw new InvalidOperationException("Saldo insuficiente.");

        Balance -= amount;
    }

    public void Credit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor a ser creditado deve ser maior que zero.", nameof(amount));

        Balance += amount;
    }
}