using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1Fixed
{
    public class CSVreaderNew
    {
        /// <summary>
        /// Takes a csv filename which is a path to one of the stocks in Stock Data. Then it
        /// Parses through the csv file and creates an instance of the candlestick for each date 
        /// in the file. It puts each instance of the candlestick class into a list then uses the 
        /// the start and end dates from FormInitial to remove any candlesticks that aren't within the
        /// range of dates. It then returns this list of filtered candlesticks
        /// </summary>
        /// <param name="csv"></param>
        /// <returns></returns>
        public static List<Candlestick> ReadCSV(string csv)
        {
            List<string> listStocks = System.IO.File.ReadAllLines(csv).Skip(1).ToList();
            var stocksAllDays = from l in listStocks
                             let data = l.Split(',')

                             select new Candlestick
                             {
                                 Day = data[0],
                                 Open = decimal.Parse(data[1]),
                                 High = decimal.Parse(data[2]),
                                 Low = decimal.Parse(data[3]),
                                 Close = decimal.Parse(data[4]),
                                 //Volume = long.Parse(data[5]),
                             };
            List<Candlestick> stocksDated = stocksAllDays.ToList();

            return stocksDated;
        }
    }
}
