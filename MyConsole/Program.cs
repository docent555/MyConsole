using System;
using System.Collections.Generic;
using System.IO;

namespace MyConsole
{
    public class Program
    {       
        static void Main(string[] args)
        {
            //Position position = new Position();

            levels = new List<Level>();

            Load();                     

            WriteLine();

            priceUp = decimal.Parse(ReadLine("\nЗадайте верхнюю цену: "));

            priceDown = int.Parse(ReadLine("Введите нижнюю цену: "));

            StepLevel = decimal.Parse(ReadLine("Введите шаг уровня: "));

            lotLevel = decimal.Parse(ReadLine("Введите лот на уровень: "));

            WriteLine();

            Save();

            Console.ReadLine();
        }
        
        //=============================================== Fields ===============================================
        #region Fields

        static decimal priceUp;

        static decimal priceDown;

        static List<Level> levels;

        static decimal lotLevel;

        #endregion


        //=============================================== Properties ==========================================
        #region Properties

        static decimal StepLevel
        {
            get
            {
                return stepLevel;
            }

            set
            {
                if (value <= 100)
                {
                    stepLevel = value;

                    decimal priceLevel = priceUp;

                    levels = Level.CalculateLevels(priceUp, priceDown, stepLevel);
                }                
            }
        }
        static decimal stepLevel;

        #endregion


        //=============================================== Methods ===============================================
        #region Methods

        static void Save()
        {
            using (StreamWriter writer = new StreamWriter("params.txt", false))
            {
                writer.WriteLine(priceUp.ToString());

                writer.WriteLine(priceDown.ToString());

                writer.WriteLine(levels.Count.ToString());
            }
        }

        static void Load()
        {
            using (StreamReader reader = new StreamReader("params.txt"))
            {
                int index = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    index++;

                    switch (index)
                    {
                        case 1: priceUp = decimal.Parse(line); break;
                        case 2: priceDown = decimal.Parse(line); break;
                        case 3: StepLevel = decimal.Parse(line); break;
                    }

                    if (line == null)
                        break;
                }
            }

            //try
            //{
            //    StreamReader reader = new StreamReader("params.txt");

            //    int index = 0;

            //    while (true)
            //    {
            //        string line = reader.ReadLine();

            //        index++;

            //        switch (index)
            //        {
            //            case 1: priceUp = decimal.Parse(line); break;
            //            case 2: priceDown = decimal.Parse(line); break;
            //            case 3: StepLevel = decimal.Parse(line); break;
            //        }       

            //        if (line == null)
            //            break;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

        static void WriteLine()
        {
            Console.WriteLine("\nКол-во элементов в списке: " + levels.Count.ToString() + "\n");

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i].PriceLevel);
            }
        }

        static string ReadLine(string message)
        {
            Console.Write(message);

            string str = Console.ReadLine() ?? "0";

            return str;
        }
        
        #endregion
    }
}

