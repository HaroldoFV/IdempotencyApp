using ConsoleApp1.Domain;

namespace ConsoleApp1.Repositories;

public interface IBankAccountRepository
{
    BankAccount GetByNumber(string number);
    void Update(BankAccount account);
}