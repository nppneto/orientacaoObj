using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class Conta
    {
        public string Numero;
        public double Saldo;
        public double Limite;
        public Agencia Agencia;

        public Conta(Agencia agencia)
        {
            this.Agencia = agencia;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine("SALDO: " + this.Saldo);
            //Extrato últimos 15 dias
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }

        public void Transfere(Conta destino, double valor)
        {
            this.Saldo -= valor;
            destino.Saldo += valor;
        }


    }
}
