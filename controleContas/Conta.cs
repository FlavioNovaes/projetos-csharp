using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero)
        {
            this.Numero = numero;
        }
        public Conta() { 
        }
        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
        public static decimal SaldoTotalGeral { get; private set; }
        public void AtualizarSaldo(decimal novoSaldo)
        {
            if (novoSaldo > this.Saldo)
            {
                this.Saldo = novoSaldo;
            }

            SaldoTotalGeral += this.Saldo;
        }
    }
}
