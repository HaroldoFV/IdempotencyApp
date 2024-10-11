namespace ConsoleApp1.Domain;

public class Transaction(
    string id,
    BankAccount sourceAccount,
    BankAccount destinationAccount,
    decimal amount)
{
    public string Id { get; } = id;
    public BankAccount SourceAccount { get; } = sourceAccount;
    public BankAccount DestinationAccount { get; } = destinationAccount;
    public decimal Amount { get; } = amount;
}