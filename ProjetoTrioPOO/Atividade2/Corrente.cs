using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade2
{
    class Corrente : Conta
    {
        public override void CalcularImposto(double saque)
        {
            double result = saque * 0.15;
            Console.WriteLine("O desconto padrão da Corrente será de: " + result);
        }
    }
}
