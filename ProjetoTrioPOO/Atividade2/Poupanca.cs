using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Atividade2508
{
	class Poupanca : Conta
	{
		public override void CalcularImposto(double saque)
		{
			double result = saque * 0.06;
			Console.WriteLine("O desconto padrão da Poupança será de: " + result);

		}
	}
}
