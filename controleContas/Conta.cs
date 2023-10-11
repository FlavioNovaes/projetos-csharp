using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero, Cliente titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }
        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
        public Cliente Titular { get; private set; }
        public static decimal SaldoTotalGeral { get; private set; }

        public decimal Saque(decimal ValorSaque)
        {
            if (ValorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque");
                return Saldo;
            }
            
            Saldo -= ValorSaque;
            return Saldo;
        }
        public void AtualizarSaldo(decimal novoSaldo)
        {
            Saldo += novoSaldo;
            SaldoTotalGeral += Saldo;
        }
    }
}
