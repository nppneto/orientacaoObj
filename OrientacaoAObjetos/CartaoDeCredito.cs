using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class CartaoDeCredito
    {
        public string Numero;
        public string DataValidade;
        public Cliente Cliente;

        public CartaoDeCredito(string numero)
        {
            this.Numero = numero;
        }
    }
}
