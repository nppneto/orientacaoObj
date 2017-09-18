using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaCartaoDeCredito
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito("123456");
            cdc1.DataValidade = "01/01/2020";

            CartaoDeCredito cdc2 = new CartaoDeCredito("654321");
            cdc2.DataValidade = "01/02/2021";

            Console.WriteLine("Dados do primeiro cartão");
            Console.WriteLine("Número: " + cdc1.Numero);
            Console.WriteLine("Data de validade: " + cdc1.DataValidade);

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Dados do segundo cartão");
            Console.WriteLine("Número: " + cdc2.Numero);
            Console.WriteLine("Data de validade: " + cdc2.DataValidade);

            Console.ReadLine();
        } 
    }
}
