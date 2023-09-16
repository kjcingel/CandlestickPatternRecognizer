using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Fixed
{
    public class recognizer_BlackMarubozu : Recognizer
    {
        //Defines the name of the recognizer 
        public override string usedPattern() { return "Black Marubozu"; }
        /// <summary>
        /// Takes in a list of Candlestick called candlesticks as a parameter. Creates a local List of integers called result. Checks each
        /// Candlestick in the list of candlesticks to see if they match the IsBlackMarubozu function. If they do then the index is added
        /// to the result list. The result list is returned at the end. 
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public override List<int> recognize(List<Candlestick> candlesticks)
        {
            List<int> result = new List<int>(candlesticks.Count / 2);
            int i = 0;
            foreach (Candlestick candle in candlesticks)
            {
                if (candle.IsBlackMarubozu())
                    result.Add(i);
                i++;
            }
            return result;
        }
    }
}
