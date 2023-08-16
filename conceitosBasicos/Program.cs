// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Hello, World!");

int num1 = 20;
int num2 = 22;
int soma = num1 + num2;
Console.WriteLine($"A soma entre {num1} e {num2} é {soma}");

float pi = 3.141697f;
decimal salario = 4343535.3433m;
Console.WriteLine("PI: {0}", pi.ToString(CultureInfo.InvariantCulture));

// double salario = 1270.50;
//int valor = (int) salario;
//Console.WriteLine(valor);

Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());
