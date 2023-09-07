// See https://aka.ms/new-console-template for more information

using controleContas;

Conta conta1 = new Conta(123456);
Conta conta2 = new Conta(654321);
conta2.Saldo = 2341.42m;
conta1.Saldo = conta2.Saldo * 0.7m;

conta1.AtualizarSaldo(1000m);
conta2.AtualizarSaldo(2000m);

Console.WriteLine($"Número da Conta: {conta1.Numero} com saldo {conta1.Saldo}");
Console.WriteLine($"Número da Conta: {conta2.Numero} com saldo {conta2.Saldo}");
Console.WriteLine($"Saldo total geral: {Conta.SaldoTotalGeral}");