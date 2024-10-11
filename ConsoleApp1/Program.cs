using ConsoleApp1.Domain;
using ConsoleApp1.Repositories;
using ConsoleApp1.Services;

var repositorio = new SimulatedBankAccountRepository();
var servicoTransferencia = new TransferService();

var contaOrigem = repositorio.GetByNumber("12345-6");
var contaDestino = repositorio.GetByNumber("78901-2");

var transacao1 = new Transaction("T123", contaOrigem, contaDestino, 100.00m);
var transacao2 = new Transaction("T123", contaOrigem, contaDestino, 100.00m); // Same transaction
var transacao3 = new Transaction("T124", contaOrigem, contaDestino, 50.00m); // New transaction

servicoTransferencia.PerformTransfer(transacao1);
servicoTransferencia.PerformTransfer(transacao2); // This will be ignored
servicoTransferencia.PerformTransfer(transacao3);

Console.WriteLine($"Saldo final da conta {contaOrigem.Number}: R$ {contaOrigem.Balance}");
Console.WriteLine($"Saldo final da conta {contaDestino.Number}: R$ {contaDestino.Balance}");