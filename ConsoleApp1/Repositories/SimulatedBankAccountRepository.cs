using ConsoleApp1.Domain;

namespace ConsoleApp1.Repositories;

public class SimulatedBankAccountRepository : IBankAccountRepository
{
    private readonly Dictionary<string, BankAccount> _accounts = new();


    public SimulatedBankAccountRepository()
    {
        _accounts["12345-6"] = new BankAccount("12345-6", 1000m);
        _accounts["78901-2"] = new BankAccount("78901-2", 500m);
    }

    public BankAccount GetByNumber(string number)
    {
        if (_accounts.TryGetValue(number, out var account))
            return account;

        throw new KeyNotFoundException($"Conta {number} não encontrada.");
    }

    public void Update(BankAccount account)
    {
        _accounts[account.Number] = account;
    }
}