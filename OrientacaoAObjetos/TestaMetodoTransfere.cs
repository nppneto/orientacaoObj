using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaMetodoTransfere
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia("1234");

            Conta origem = new Conta(a);
            origem.Saldo = 1000;
            Console.WriteLine("Saldo da primeira conta: " + origem.Saldo);

            Conta destino = new Conta(a);
            destino.Saldo = 1000;
            Console.WriteLine("Saldo da segunda conta: " + destino.Saldo);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Realizando a trânsferencia...");
            origem.Transfere(destino, 500);

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Saldo da primeira conta: " + origem.Saldo);
            Console.WriteLine("Saldo da segunda conta: " + destino.Saldo);

            Console.ReadLine();

        }
    }
}
