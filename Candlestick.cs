using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;

namespace Project1Fixed
{
    //Creates the getters and settes for the candlestick class
    public class Candlestick
    {
        public string Day { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public long Volume { get; set; }

        public Candlestick() 
        {
        }
        //Creates the property Range of the candlestick Class
        public decimal Range
        {
            get { return Math.Abs(High - Low); }
            set { Range = value; }
        }
        //Creates the property Body of the candlestick Class
        public decimal Body 
        {
            get { return Math.Abs(Close - Open); }
            set { Body = value; }
        }
        //Creates the property TopTail of the candlestick Class
        public decimal TopTail
        {
            get { return High - Math.Max(Close, Open); }
            set { TopTail = value; }
        }
        //Creates the property BottomTail of the candlestick Class
        public decimal BottomTail
        {
            get { return Math.Min(Close, Open) - Low;}
            set { BottomTail = value; }
        }
        
        //Method that checks if a candlestick is a common doji
        public bool IsDoji()
        {
            return (Body < (decimal)(0.05) * Range);
        }
        //Method that checks if a candlestick is a dragonfly doji
        public bool IsDragonFlyDoji()
        {
            if (IsDoji() && TopTail < (decimal)0.05 * Range){ return true; }
            else { return false;}
        }
        //Method that checks if a candlestick is a gravestone doji
        public bool IsGraveStoneDoji()
        {
            if (IsDoji() && BottomTail < (decimal)0.05 * Range) { return true; }
            else { return false;}
        }
        //Method that checks if a candlestick is a White Marubozu candle
        public bool IsWhiteMarubozu()
        {
            if (Body > (decimal)0.95 * Range && Close > Open) { return true; }
            else { return false; }
        }
        //Method that checks if a candlestick is a Black Marubozu candle
        public bool IsBlackMarubozu()
        {
            if (Body > (decimal)0.95 * Range && Open > Close) { return true; }
            else { return false;}
        }
        //Method that checks if a candlestick is a long legged doji candle
        public bool IsLongLeggedDoji()
        {
            if (IsDoji() && BottomTail > (decimal)0.3 * Range && TopTail > (decimal)0.3 * Range) { return true; }
            else { return false;} 
        }
        //Method that checks if a candlestick is either red or green
        public bool IsGreenOrRed()
        {
            //Green Candle
            if (Close > Open) { return true;}
            //Red Candle
            else { return false;}
        }
        //Method that checks if a candlestick is a Bearish Hammer
        public bool IsBearishHammer()
        {
            if (IsGreenOrRed() == true && BottomTail < (decimal)0.03 * Range && TopTail > (decimal)0.2 * Range) { return true; }
            else { return false; }
        }
        //Method that checks if a candlestick is a Bullish Hammer
        public bool IsBullishHammer()
        {
            if (IsGreenOrRed() == false && TopTail < (decimal)0.03 * Range && BottomTail > (decimal)0.2 * Range) { return true; }
            else { return false; }
        }
        //Method that checks if a candlestick is an Inverted Hammer
        public bool IsInvertedHammer()
        {
            if(IsGreenOrRed() == false && BottomTail < (decimal)0.03 * Range && TopTail > (decimal)0.2 * Range) { return true; }
            else if(IsGreenOrRed() == true && TopTail < (decimal)0.03 * Range && BottomTail > (decimal)0.2 * Range) { return true; }
            else { return false; }
        }
        
    }   
}
