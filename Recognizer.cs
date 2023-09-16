using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Fixed
{
    abstract public class Recognizer
    {
        //Requires that each class derived from Recognizer needs a list of the Candlestick class
        public abstract List<int> recognize(List<Candlestick> candlesticks);
        //Requires that each class derived from Recognizer needs a string that would identify the recognizer
        public abstract string usedPattern();

    }
}
