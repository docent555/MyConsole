namespace MyConsole
{
    internal class Program
    {
        static decimal priceUp;

        static decimal priceDown;

        static decimal stepLevel;

        static List<decimal> levels;

        static void Main(string[] args)
        {
            levels = new List<decimal>();

            WriteLine();

            priceUp = decimal.Parse(ReadLine("Задайте верхнюю цену: "));

            priceDown = int.Parse(ReadLine("Введите нижнюю цену: "));

            StepLevel = decimal.Parse(ReadLine("Введите шаг уровня: "));

            WriteLine();
        }

        static decimal StepLevel
        {
            get
            {
                return stepLevel;
            }

            set
            {
                stepLevel = value;

                decimal priceLevel = priceUp;

                while (priceLevel >= priceDown)
                {
                    levels.Add(priceLevel);

                    priceLevel -= stepLevel;
                }
            }
        }

        static void WriteLine()
        {
            Console.WriteLine("\nКол-во элементов в списке: " + levels.Count.ToString() + "\n");

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i]);
            }
        }

        static string ReadLine(string message)
        {
            Console.Write(message);

            string str = Console.ReadLine() ?? "0";

            return str;
        }
    }
}

