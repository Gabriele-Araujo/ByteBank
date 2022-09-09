using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Antes do saque: " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine("Resultado: " + resultadoSaque);
            Console.WriteLine("Depois do saque: " + contaDoBruno.saldo);

            Console.WriteLine("Saldo antes do deposito: " + contaDoBruno.saldo);
            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo após o deposito: " + contaDoBruno.saldo);
            Console.WriteLine();


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno antes da transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela antes da transferência: " + contaDaGabriela.saldo);
            Console.WriteLine();

            bool resultadoTransferencia = contaDoBruno.Tranferir(200, contaDaGabriela);
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do Bruno depois da transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela depois da transferência: " + contaDaGabriela.saldo);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Saldo do Bruno antes da transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela antes da transferência: " + contaDaGabriela.saldo);
            Console.WriteLine();

            resultadoTransferencia = contaDaGabriela.Tranferir(100, contaDoBruno);
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do Bruno depois da transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela depois da transferência: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
