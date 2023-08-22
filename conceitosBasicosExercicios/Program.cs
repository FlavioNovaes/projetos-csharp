// See https://aka.ms/new-console-template for more information

using conceitosBasicosExercicios;

int n1 = 20;
int n2 = 11, result;

Somador soma;
soma = new Somador();

Conversor conversor = new Conversor();

result = soma.Soma(n1, n2);

Console.WriteLine(result);
Console.WriteLine(conversor.MetrosMilimetros(1.76));