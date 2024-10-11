using ConsoleApp1.Domain;

namespace ConsoleApp1.Services;

public interface ITransferService
{
    bool PerformTransfer(Transaction transaction);
}