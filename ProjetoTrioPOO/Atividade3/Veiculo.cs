using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade3
{
    internal class Veiculo
    {
        public string placa;
        public string cor;
        public string modelo;

        public virtual void CalcularValorCombustivel()
        {
            Console.WriteLine("Escolha qual opção de combustivel você gostaria de abastecer: 1 - Alcool 2 - Gasolina e  3- Diesel");
            int combustivel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a quantidade de litros que você ira querer");
            int litros = Convert.ToInt32(Console.ReadLine());

            if (combustivel == 1)
            {
                double result = litros * 3.99;
                Console.WriteLine(" VOcê escolheu Álcool o resultado foi de:" + result);
            }
            else if (combustivel == 2)
            {
                double result = litros * 5.99;
                Console.WriteLine(" VOcê escolheu Gasolina o resultado foi de:" + result);
            }
            else if (combustivel == 3)
            {
                double result = litros * 6.99;
                Console.WriteLine(" VOcê escolheu Diesel o resultado foi de:" + result);
            }

        }

        public virtual void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de pessoas que irão para a viagem");
            int pessoas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de km a ser percorrida na viagem");
            int km = Convert.ToInt32(Console.ReadLine());

            if (pessoas == 2 || km > 50)
            {
                Console.WriteLine(km * 25.00);
            }
            else if (pessoas == 2 || km < 50)
            {
                Console.WriteLine(km * 18.00);
            }
            else
            {
                Console.WriteLine(km * 15.00);
            }
        }
    }
}
