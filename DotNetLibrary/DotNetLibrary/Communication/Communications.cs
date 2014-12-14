using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary
{
    public enum MainMenu
    {
        NULL = 0,
        CLOSE_GAME,
        START_GAME,
        ERROR
    };

    public enum Gender
    {
        MALE = 0,
        FEMALE,
        ALIEN
    };
     

    public enum Stock
    {
        NO_STOCK = 0,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE
    };

    public class Conversion
    {
        public Stock stockFromInt(int number)
        {
            if(number <= 0 || number >= Enum.GetNames(typeof(Stock)).Length)
            {
                return Stock.NO_STOCK;
            }

            return (Stock)number;
        }

        public int intFromStock(Stock stock)
        {
            return (int)stock;
        }
    }

}
