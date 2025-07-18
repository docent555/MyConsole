﻿using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace MyConsole
{
    public class Position
    {
        public Position()
        {
            System.Timers.Timer timer = new System.Timers.Timer();

            timer.Interval = 1000;

            timer.Elapsed += Timer_Elapsed;

            timer.Start();
        }

        Random random = new Random();

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();

            int num = random.Next(-10, 10);

            if (num > 0)
            {
                // Сделка в лонг
            }
            else if (num < 0)
            {
                // Сделка в шорт
            }

            trade.Volume = Math.Abs(num);  

            trade.Price = random.Next(70000,80000);

            string str = "Volume = " + trade.Volume. ToString() + " / Price = " + trade.Price.ToString();

            Console.WriteLine(str);
        }
    }
}
