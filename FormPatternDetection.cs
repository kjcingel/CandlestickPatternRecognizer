using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project1Fixed
{
    public partial class FormPatternDetection : Form
    {
        //Creates a variable that holds the list of candlesticks, list of recognizers, and indexes so they can be used throughout the class
        public List<Candlestick> dataStock;
        public List<Recognizer> recognizers = null;
        public List<int> indicies = null;

        /// <summary>
        /// FormPatternDetection takes the parameter stockData so the rest of the class can use the list of candlesticks and 
        /// tickerText is used to display the name of the ticker chosen. The gridview and chartview are both loaded as the form is 
        /// opened, the variable dataStock is set equal to the list of candlesticks and a label is set equal to the tickerText so the 
        /// user knows what ticker they chose.
        /// </summary>
        /// <param name="stockData"></param>
        /// <param name="tickerText"></param>
        public FormPatternDetection(List<Candlestick> stockData, string tickerText)
        {
            InitializeComponent();
            SetGridView(stockData);
            SetChartView(stockData);
            InitializeRecognizers();
            string[] subs = tickerText.Split('\\'); string[] subs2 = subs[1].Split('-');
            labelTickerDisplay.Text = subs2[0];
            dataStock = stockData;
        }
        /// <summary>
        /// Tells the user what pattern they chose by taking the .Text value from the combo box, clears all current annotations on the
        /// chart, then runs the checkPattern method which displays all the instances of the chosen pattern on the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void comboBoxPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDisplayingPattern.Text = "Displaying the "+ comboBoxPattern.Text + " pattern";
            chartCandlestick.Annotations.Clear();
            int i = comboBoxPattern.SelectedIndex;
            Recognizer r = recognizers[i];
            indicies = r.recognize(dataStock);
            foreach (int index in indicies)
            {
                DataPoint dataPoint = chartCandlestick.Series["Daily"].Points[index];
                
                LineAnnotation arrowAnnotation = new LineAnnotation();
                arrowAnnotation.AnchorDataPoint = dataPoint;
                arrowAnnotation.StartCap = LineAnchorCapStyle.Arrow;
                arrowAnnotation.Width = 2;
                arrowAnnotation.Height = 4;
                arrowAnnotation.LineColor = Color.Black;
                chartCandlestick.Annotations.Add(arrowAnnotation);
            }
        }
        /// <summary>
        /// Creates a list of the Recognizer class and adds each Derived Recognizer class to the list.
        /// Each item of the recognizers list is added to the pattern combo box
        /// </summary>
        public void InitializeRecognizers()
        {
            recognizers = new List<Recognizer>
            {
                new recognizer_Doji(),
                new recognizer_GravestoneDoji(),
                new recognizer_DragonFlyDoji(),
                new recognizer_LongLeggedDoji(),
                new recognizer_BlackMarubozu(),
                new recognizer_WhiteMarubozu(),
                new recognizer_BullishHammer(),
                new recognizer_BearishHammer(),
                new recognizer_InvertedHammer(),
                new recognizer_BullishEngulfing(),
                new recognizer_BearishEngulfing()
            };

            foreach (Recognizer r in recognizers)
            {
                comboBoxPattern.Items.Add(r.usedPattern());
            }
        }
        /// <summary>
        /// Takes in the list of candlesticks and checks what the lowest value of each one is so it can be used
        /// to make the chart look neater.
        /// </summary>
        /// <param name="stockDataList"></param>
        /// <returns></returns>
        public double MinCandleValue(List<Candlestick> stockDataList)
        {
            decimal min = 1000;
            foreach (Candlestick element in stockDataList)
            {
                if (element.Low < min)
                {
                    min = element.Low;
                }
            }
            return (double)min;
        }
        /// <summary>
        /// Takes in the list of candlesticks and checks what the highest value of each one is so it can be used
        /// to make the chart look neater.
        /// </summary>
        /// <param name="stockDataList"></param>
        /// <returns></returns>
        public double MaxCandleValue(List<Candlestick> stockDataList)
        {
            decimal max = 0;
            foreach (Candlestick element in stockDataList)
            {
                if (element.High > max)
                {
                    max = element.High;
                }
            }
            return (double)max;
        }
        /// <summary>
        /// Sets all the properties of the chart. Takes in a list of candlesticks that it uses as its data source.
        /// </summary>
        /// <param name="stockDataList"></param>
        public void SetChartView(List<Candlestick> stockDataList)
        {
            chartCandlestick.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartCandlestick.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chartCandlestick.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "0.00";
            chartCandlestick.ChartAreas["ChartArea1"].AxisY.Minimum = MinCandleValue(stockDataList) - 5;
            chartCandlestick.ChartAreas["ChartArea1"].AxisY.Maximum = MaxCandleValue(stockDataList) + 5;


            //Initiate the chart properties
            chartCandlestick.Series["Daily"].XValueMember = "Day";
            chartCandlestick.Series["Daily"].YValueMembers = "High,Low,Open,Close";
            chartCandlestick.Series["Daily"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartCandlestick.Series["Daily"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
            chartCandlestick.Series["Daily"]["OpenCloseStyle"] = "Triangle";
            chartCandlestick.Series["Daily"]["ShowOpenClose"] = "Both";
            chartCandlestick.DataManipulator.IsStartFromFirst = true;

            //Refresh the chart data and set its database
            chartCandlestick.DataBind();
            chartCandlestick.DataSource = stockDataList;
            chartCandlestick.Refresh();
        }
        /// <summary>
        /// Sets all the properties of the Grid View. Takes in a list of candlesticks that it uses as its data source.
        /// </summary>
        /// <param name="stockDataList"></param>
        public void SetGridView(List<Candlestick> stockDataList)
        {
            dataGridView2.DataSource = stockDataList;
            dataGridView2.Refresh();
        }
    }
}
