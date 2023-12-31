﻿using System;
using System.Threading;

namespace CRONOMETRO
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s");
            Console.WriteLine("M = Minuto => 1m");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (type == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
            Console.WriteLine(type);
            Console.WriteLine(time);


        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready....");
            Thread.Sleep(1000);
            Console.WriteLine("Set....");
            Thread.Sleep(1000);
            Console.WriteLine(1000);
            Starte(time);
        }
        static void Starte (int time)
        {
            int matual = 0;
            while (matual != time)
            {
                Console.Clear();
                ++matual;
                Console.WriteLine(matual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Finalizado");
            Thread.Sleep(2500);
        }
 

     
    }
}
