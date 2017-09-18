using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class Gerente
    {
        public string Nome;
        public double Salario;

        public void AumentaSalario()
        {
            this.AumentaSalario(0.1);
        }

        public void AumentaSalario(double Taxa)
        {
            this.Salario += this.Salario * Taxa;
        }
    }
}
