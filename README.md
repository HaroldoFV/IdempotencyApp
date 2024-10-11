# Bank Transfer Idempotency Simulation

## English

This project simulates idempotency in bank transfers. Idempotency ensures that an operation can be repeated multiple times without changing the result beyond its initial application.

Key features:
- Simulates bank accounts and transfers
- Implements idempotent transfer operations
- Demonstrates how repeated transfer requests with the same ID are ignored
- Uses object-oriented programming principles

The `TransferService` class maintains a record of processed transactions, ensuring each unique transaction is processed only once, regardless of how many times it's submitted.

## Português

# Simulação de Idempotência em Transferências Bancárias

Este projeto simula idempotência em transferências bancárias. Idempotência garante que uma operação pode ser repetida várias vezes sem alterar o resultado além de sua aplicação inicial.

Características principais:
- Simula contas bancárias e transferências
- Implementa operações de transferência idempotentes
- Demonstra como solicitações repetidas de transferência com o mesmo ID são ignoradas
- Utiliza princípios de programação orientada a objetos

A classe `TransferService` mantém um registro das transações processadas, garantindo que cada transação única seja processada apenas uma vez, independentemente de quantas vezes seja submetida.