using System;
using System.Globalization;
using ConsoleApp1;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaBancaria conta;

      System.Console.Write("Entre com um número da conta: ");
      int numero = int.Parse(Console.ReadLine() ?? "");
      System.Console.Write("Entre com um titular da conta: ");
      string titular = Console.ReadLine() ?? "";
      System.Console.Write("Haverá depósito inicial (s/n)? ");
      char resposta = char.Parse(Console.ReadLine() ?? "");
      if (resposta == 's' || resposta == 'S')
      {
        System.Console.Write("Entre o valor de depósito inicial: ");
        double depositoInicial = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
        conta = new ContaBancaria(numero, titular, depositoInicial);
        Console.WriteLine(conta);
      }
      else
      {
        conta = new ContaBancaria(numero, titular);
        Console.WriteLine(conta);
      }
      Console.WriteLine();
      Console.Write("Entre um valor para depósito: ");
      double quantia = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
      conta.Deposito(quantia);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(conta);

      Console.WriteLine();
      Console.Write("Entre um valor para saque: ");
      quantia = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
      conta.Saque(quantia);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(conta);
    }
  }
}