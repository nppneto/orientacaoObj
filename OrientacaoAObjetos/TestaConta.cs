using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia("123");

            Conta c1 = new Conta(a);
            c1.Numero = "1234";
            c1.Saldo = 1000;
            c1.Limite = 500;

            Conta c2 = new Conta(a);
            c2.Numero = "5678";
            c2.Saldo = 2000;
            c2.Limite = 250;

            Console.WriteLine("Dados da primeira conta");
            Console.WriteLine("Número: " + c1.Numero);
            Console.WriteLine("Saldo atual: " + c1.Saldo);
            Console.WriteLine("Limite disponível: " + c1.Limite);

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Dados da segunda conta");
            Console.WriteLine("Número: " + c2.Numero);
            Console.WriteLine("Saldo atual: " + c2.Saldo);
            Console.WriteLine("Limite disponível: " + c2.Limite);

            Console.ReadLine();
        }
    }
}
