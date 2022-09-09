using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "434.562.878-20";
            gabriela.profissao = "Desenvolvedora C#";*/

            ContaCorrente contaDaGabriela = new ContaCorrente();
            //contaDaGabriela.titular = gabriela;
            contaDaGabriela.titular = new Cliente();
            Console.WriteLine(contaDaGabriela.titular.nome);

            contaDaGabriela.titular.nome = "Gabriela Costa";
            contaDaGabriela.titular.cpf = "434.562.878-20";
            contaDaGabriela.titular.profissao = "Desenvolvedora C#";
            contaDaGabriela.agencia = 563;
            contaDaGabriela.numero = 5634527;
            contaDaGabriela.saldo = 500;

            /*gabriela.nome = "Gabriela Costa";
            Console.WriteLine(gabriela.nome);*/

            Console.WriteLine(contaDaGabriela.titular.nome);
            Console.WriteLine(contaDaGabriela.titular.cpf);
            Console.WriteLine(contaDaGabriela.titular.profissao);

            Console.ReadLine();
        }
    }
}
