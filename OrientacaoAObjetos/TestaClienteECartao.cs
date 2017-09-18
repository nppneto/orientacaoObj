using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaClienteECartao
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito("123456");

            c.Nome = "Nelson Neto";
            c.Codigo = "123";

            cdc.DataValidade = "28/02/2025";

            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: " + c.Nome);
            Console.WriteLine("Código: " + c.Codigo);

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Dados do cartão");
            Console.WriteLine("Número: " + cdc.Numero);
            Console.WriteLine("Data de validade: " + cdc.DataValidade);

            Console.WriteLine("-------------------------------------------------");

            cdc.Cliente = c;

            Console.WriteLine("Dados do cliente através do cartão");
            Console.WriteLine("Nome: " + cdc.Cliente.Nome);
            Console.WriteLine("Código: " + cdc.Cliente.Codigo);

            Console.ReadLine();
        }
    }
}
