using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade3
{
    class Uber : Veiculo
    {
        private int QtdeRodas;
        private int QtdePassageiros;

        public virtual void EscolherVeiculo()
        {


        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de km que irá ser percorrido");
            double DistPercorrido = Convert.ToInt32(Console.ReadLine());

            double resultkm = DistPercorrido * 11.99;
            Console.WriteLine("O resultado deu " + resultkm);
        }
    }
}
