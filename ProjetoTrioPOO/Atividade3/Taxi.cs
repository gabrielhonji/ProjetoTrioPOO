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
        public double paymentSplit;
        public override void CalcularValorCombustivel()
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
        public override void CalcularTotal()
        {
            Console.Write("Quantas pessoas farão a viagem: ");
            passengersAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidades de Kms a serem rodados durante a viagem: ");
            double km = Convert.ToInt32(Console.ReadLine());
            if (passengersAmount == 2 && km > 30 )
            {
                payAmount = km * 20;
                paymentSplit = payAmount / passengersAmount;
                Console.WriteLine($"Em uma viagem de {km} Km para {passengersAmount} passageiros o valor total a ser pago é igual a R$ {payAmount}, que dividido igualmente pelos passageiros é igual a R$ {paymentSplit} para cada");
            }
            else if (passengersAmount == 3 && km > 30)
            {
                payAmount = km * 35;
                paymentSplit = payAmount / passengersAmount;
                Console.WriteLine($"Em uma viagem de {km} Km para {passengersAmount} passageiros o valor total a ser pago é igual a R$ {payAmount}, que dividido igualmente pelos passageiros é igual a R$ {paymentSplit} para cada");
            }
            else if (passengersAmount == 4 && km > 30)
            {
                payAmount = km * 50;
                paymentSplit = payAmount / passengersAmount;
                Console.WriteLine($"Em uma viagem de {km} Km para {passengersAmount} passageiros o valor total a ser pago é igual a R$ {payAmount}, que dividido igualmente pelos passageiros é igual a R$ {paymentSplit} para cada");
            }
            else if (passengersAmount == 2 || passengersAmount == 3 || passengersAmount == 4 && km <= 30)
            {
                payAmount = km * 10;
                paymentSplit = payAmount / passengersAmount;
                Console.WriteLine($"Em uma viagem de {km} Km para {passengersAmount} passageiros o valor total a ser pago é igual a R$ {payAmount}, que dividido igualmente pelos passageiros é igual a R$ {paymentSplit} para cada");
            }
            else
            {
                payAmount = km * 18;
                paymentSplit = payAmount / passengersAmount;
                Console.WriteLine($"Em uma viagem de {km} Km para {passengersAmount} passageiros o valor total a ser pago é igual a R$ {payAmount}, que dividido igualmente pelos passageiros é igual a R$ {paymentSplit} para cada");
            }
        }
}
