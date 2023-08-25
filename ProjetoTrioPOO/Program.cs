﻿using ProjetoTrioPOO.Atividade1;
using ProjetoTrioPOO.Atividade2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex01
            Console.WriteLine("Digite o seu salario");
            Double salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o seu irrf");
            Double irrf = Convert.ToInt32(Console.ReadLine());
            Colaborador colaborador = new Colaborador();
            colaborador.CalcularSalario(salario);
            colaborador.CalcularIRRF(irrf);
            Console.WriteLine();

            Professor professor = new Professor();
            professor.CalcularSalario(salario);
            professor.CalcularIRRF(irrf);
            Console.WriteLine();

            Coordenador coordenador = new Coordenador();
            coordenador.CalcularSalario(salario);
            coordenador.CalcularIRRF(irrf);
            Console.WriteLine();

            Diretor diretor = new Diretor();
            diretor.CalcularSalario(salario);
            diretor.CalcularIRRF(irrf);

            // Ex02
            Console.WriteLine("Digite o Valor do Saque");
            double saque = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Poupança -----------");
            Poupanca poupanca = new Poupanca();

            poupanca.CalcularImposto(saque);
            Console.WriteLine();

            Console.WriteLine("Corrente -----------");
            Corrente corrente = new Corrente();

            corrente.CalcularImposto(saque);

            // Ex03
            Atividade3.Taxi taxi = new Atividade3.Taxi();
            taxi.CalcGasValue();
        }
    }
}
