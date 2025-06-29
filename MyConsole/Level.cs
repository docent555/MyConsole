using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Level
    {
        public Level() 
        {
            //PriceLevel = price;
        }

        //======================================================= Fiels ============================================================== 
        #region Fields

        /// <summary>
        /// Цена уровня
        /// </summary>
        public decimal PriceLevel = 0;

        /// <summary>
        /// Лот на уровень
        /// </summary>
        public static decimal LotLevel = 0;

        /// <summary>
        /// Открытый объем на уровне
        /// </summary>
        public decimal Volume = 0;

        #endregion

        //======================================================= Methods ============================================================== 

        #region Methods

        public static List<Level> CalculateLevels(decimal priceUp, int countLevels, decimal stepLevel)
        {
            List<Level> levels = new List<Level>();

            decimal priceLevel = priceUp;

            for (int i = 0; i < countLevels; i++)
            {
                Level level = new Level() { PriceLevel = priceLevel};

                levels.Add(level);

                priceLevel -= stepLevel;
            }

            return levels;
        }

        #endregion
    }
}
