using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; private set; }
        public Cliente(string nome, int idade, string cpf)
        {
            if (idade > 18)
            {
                Nome = nome;
                Idade = idade;
                CPF = cpf;
            }
            else
            {
                Console.WriteLine("Dados inválidos!");
            }
        }
    }
}
