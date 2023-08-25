using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade1
{
    class Colaborador
    {
        public virtual void CalcularSalario(double salario)
        {
            double result = salario * 0.14;
            Console.WriteLine("O desconto padrão é de: " + result);

        }
        public virtual void CalcularIRRF(double irrf)
        {
            double result = irrf * 0.02;
            Console.WriteLine("O desconto padrão é de: " + result);
        }

    }
}
