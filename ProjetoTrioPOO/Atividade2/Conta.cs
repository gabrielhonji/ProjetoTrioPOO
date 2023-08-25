using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade2
{
    class Conta
    {
        public string agencia;
        public string conta;
        public string nomeTitular;

        public virtual void CalcularImposto(double saque)
        {
            double result = saque * 0.04;
            Console.WriteLine("O desconto padrão foi de: " + result);
        }
    }
}
