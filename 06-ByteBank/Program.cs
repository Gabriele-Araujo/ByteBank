using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Gabriela";
            cliente.CPF = "434.562.878-20";
            cliente.Profissao = "Desenvolvedora C#";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.ReadLine();
        }
    }
}
