using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Fixed
{
    public class recognizer_BearishEngulfing : Recognizer
    {
        //Defines the name of the recognizer 
        public override string usedPattern() { return "Bearish Engulfing"; }
        /// <summary>
        /// Takes in a list of Candlestick called candlesticks as a parameter. Creates a local List of integers called result. Checks 2 instances
        /// of a Candlestick, the current candlestick in the loop and the candlestick directly before the current one. Then it checks if the current
        /// candle classifies as a bullish engulfing candle by comparing it the the previous candle. If it is, then its index is added to the 
        /// result list.
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public override List<int> recognize(List<Candlestick> candlesticks)
        {
            List<int> result = new List<int>(candlesticks.Count / 2);

            for (int i = 1; i < candlesticks.Count; i++)
            {
                Candlestick current = candlesticks[i];
                Candlestick previous = candlesticks[i - 1];
                if (previous.IsGreenOrRed() == true && current.IsGreenOrRed() == false && previous.Close < current.Open && previous.Open > current.Close)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
