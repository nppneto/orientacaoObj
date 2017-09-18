using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public double AumentaSalario(double Salario)
        {
           return Salario += Salario;
        }

        public void ConsultaFuncionario()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salário atual: " + AumentaSalario(Salario));
        }
    }
}
