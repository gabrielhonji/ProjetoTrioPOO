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
        public string TipoUber;
        public virtual void EscolherVeiculo()
        {
            TipoUber = Console.ReadLine();
            if (TipoUber == "UberXShare") 
            {
                Console.WriteLine("Digite quantas pessoas você deseja compartilhar o uber");
                int Pessoa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Você irá compartilhar o seu uber com "+Pessoa);
            }
            else if (TipoUber == "UberGreen")
            {
                Console.WriteLine("Parabéns, você está escolhendo um veículo ecológico");
            }
            else if (TipoUber == "UberReserve")
            {
                Console.WriteLine("Digite que dia você deseja reservar o veiculo");
                string dia = Console.ReadLine();
                Console.WriteLine("Que horario você deseja usar esse uber");
                string horario = Console.ReadLine();
                Console.WriteLine("Agora digite quantas pessoa você deseja compartilhar essa corrida");
                string Pessoa = Console.ReadLine();

                Console.WriteLine("Você marcou o uber dia "+dia+" Nó horario"+horario+" é você ira compartilhar com "+Pessoa+"pessoa");
            }
            else
            {
                Console.WriteLine("Nenhum veículo escolhido, você irá fazer a viagem com um veículo padrão daempresa.Boa viagem!!!");
            }

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
