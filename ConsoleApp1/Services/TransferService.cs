using ConsoleApp1.Domain;

namespace ConsoleApp1.Services;

public class TransferService : ITransferService
{
    private readonly Dictionary<string, bool> _processedTransactions = new();

    public bool PerformTransfer(Transaction transaction)
    {
        if (transaction == null)
            throw new ArgumentNullException(nameof(transaction));

        if (_processedTransactions.ContainsKey(transaction.Id))
        {
            Console.WriteLine($"Transação {transaction.Id} já foi processada. Ignorando...");
            return false;
        }

        try
        {
            transaction.SourceAccount.Debit(transaction.Amount);
            transaction.DestinationAccount.Credit(transaction.Amount);

            _processedTransactions[transaction.Id] = true;

            Console.WriteLine(
                $"Transferência de R$ {transaction.Amount} da conta {transaction.SourceAccount.Number} para a conta {transaction.DestinationAccount.Number} realizada com sucesso.");

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na transferência: {ex.Message}");
            return false;
        }
    }
}