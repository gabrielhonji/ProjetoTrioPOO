using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade3
{
    class Moto : Veiculo
    {
        public override void CalcularValorCombustivel()
        {
            Console.WriteLine("Escolha qual opção de combustivel você gostaria de abastecer: 1 - Alcool 2 - Gasolina");
            int combustivel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a quantidade de litros que você ira querer");
            int litros = Convert.ToInt32(Console.ReadLine());

            if (combustivel == 1)
            {
                double result = litros * 4.99;
                Console.WriteLine(" VOcê escolheu Álcool o resultado foi de:" + result);
            }
            else if (combustivel == 2)
            {
                double result = litros * 4.99;
                Console.WriteLine(" VOcê escolheu Gasolina o resultado foi de:" + result);
            }
            else
            {
                Console.WriteLine("Você digitou um combustivel inválido");
            }
        }

        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de km a ser percorrida na viagem");
            int km = Convert.ToInt32(Console.ReadLine());

            if (km >= 100 || km < 150)
            {
                Console.WriteLine( "O resultado foi de: " + km * 20.00);
            }
            else if (km >= 50)
            {
                Console.WriteLine("O resultado foi de: " + km * 10.00);
            }
            else
            {
                Console.WriteLine("O resultado foi de: " + km * 5.00);
            }
        }
    }
}
