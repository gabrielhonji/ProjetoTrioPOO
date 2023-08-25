using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO.Atividade3
{
    class Taxi : Veiculo
    {
        public int wheelAmount;
        public int passengersAmount;
        public double gasAmount;
        public double payAmount;
        public override void CalcGasValue()
        {
            Console.Write("Qual foi a quantidade de combustivel gasto: ");
            double gasAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual foi o tipo de combustivel utilizado? 1 - Álcool, 2 – Gasolina, 3 - Híbrido, 4 - GasGNV, 5 -Diesel: ");
            int gasChoice = Convert.ToInt32(Console.ReadLine());
            while (gasChoice < 1 || gasChoice > 5)
            {
                Console.Write("Desculpe, essa opção não existe, você poderia digitar novamente o tipo de combustivel utilizado? 1 - Álcool, 2 – Gasolina, 3 - Híbrido, 4 - GasGNV, 5 -Diesel: ");
                gasChoice = Convert.ToInt32(Console.ReadLine());
            }
            switch (gasChoice)
            {
                case 1:
                    payAmount = (gasAmount * 4.99) + 20;
                    Console.WriteLine($"O valor gasto de {gasAmount}L sai pela bagatela de R$ {payAmount}");
                    break;
                case 2:
                    payAmount = (gasAmount * 6.99) + 40;
                    Console.WriteLine($"O valor gasto de {gasAmount}L sai pela bagatela de R$ {payAmount}");
                    break;
                case 3:
                    payAmount = (gasAmount * 4.99) + 20;
                    Console.Write($"Digite quantas horas gostaria de deixar o veículo carregando: ");
                    double timeCharging = Convert.ToInt32(Console.ReadLine());
                    payAmount = (timeCharging * 1000) + 200;
                    Console.WriteLine($"O tempo de carregamento de {timeCharging} Horas sai pela bagatela de R$ {payAmount}");
                    break;
                case 4:
                    payAmount = 300;
                    Console.WriteLine($"O valor gasto de {gasAmount}L sai pelo valor fixo de R$ {payAmount}");
                    break;
                case 5:
                    payAmount = (gasAmount * 7.99) + 25;
                    Console.WriteLine($"O valor gasto de {gasAmount}L sai pela bagatela de R$ {payAmount}");
                    break;
            }
        }
    }
}
