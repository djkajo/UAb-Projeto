﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao programa de cálculo de consumos gás/electricidade");
            Console.WriteLine("Deseja calcular o consumo de gás ou electricidade ?");
            Console.WriteLine("Introduza G para gás e E para electricidade seguido da tecla enter");
            var opcao = Console.ReadLine();

            if (opcao == "E" || opcao == "e")
            {
                Console.WriteLine("Deseja calcular o consumo em vazio ou fora de vazio?");
                Console.WriteLine("Introduza V para vazio e F para fora de vazio seguido de enter");
                var opcaoE = Console.ReadLine();
                if (opcaoE == "V" || opcaoE == "v")
                {
                    Console.WriteLine("Introduza a contagem anterior: ");
                    int anterior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduza a contagem actual: ");
                    int actual = Convert.ToInt32(Console.ReadLine());
                    double consumo = (actual - anterior) * 0.0969;
                    Console.WriteLine("Valor: " + consumo + " euros");
                    Console.Read();
                }
                else if (opcaoE == "F" || opcaoE == "f")
                {
                    Console.WriteLine("Introduza a contagem anterior: ");
                    int anterior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduza a contagem actual: ");
                    int actual = Convert.ToInt32(Console.ReadLine());
                    double consumo = (actual - anterior) * 0.2029;
                    Console.WriteLine("Valor: " + consumo + " euros");
                    Console.Read();
                }


            }
            else if (opcao == "G" || opcao == "g")
            {
                Console.WriteLine("Introduza a contagem anterior: ");
                int anterior = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduza a contagem actual: ");
                int actual = Convert.ToInt32(Console.ReadLine());
                double consumo = (actual - anterior) * 0.98121100 * 11.80373300;
                double consumo2 = consumo * 0.0578;
                Console.WriteLine("Valor: " + consumo2 + " euros");
                Console.Read();

            }

        }
    }
}
