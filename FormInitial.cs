using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1Fixed
{
    public partial class FormInitial : Form
    {
        //Creates Start and End Date variables
        public static DateTime StartDate;
        public static DateTime EndDate;
        public FormInitial()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles("Stock Data\\", "*Day*");
            comboBoxTicker.Items.AddRange(files);
        }
        /// <summary>
        /// When a ticker is picked in the combo box, this method calls for the start and end dates from the date time pickers on form 1.
        /// It sends the startdate, enddate, and the text from combo box to the ReadCSV method out of the CSVreaderNew class. The class 
        /// returns a list of Candlestick classes called stockData. Stock data is sent to Form2 and Form2 is opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndDate = dateTimePickerEndDate.Value;
            StartDate = dateTimePickerStartDate.Value;

            string FileName = (comboBoxTicker.Text);
            List<Candlestick> stockData = CSVreaderNew.ReadCSV(FileName);

            var filter = stockData.Where(x => (DateTime.Parse(x.Day.Replace("\"", String.Empty)) >= StartDate) && (DateTime.Parse(x.Day.Replace("\"", String.Empty)) <= EndDate)).ToList();
            FormPatternDetection f2 = new FormPatternDetection(filter, comboBoxTicker.Text);
            f2.Show();
        }

        /// <summary>
        /// Takes in the value of each radio button (daily, weekly, monthly) and decides if they
        /// are checked or not. Then it sets the timeframe variable equal to a string that corresponds to the
        /// radio button that was checked. This string is returned so that the CSV reader class knows which
        /// timeframe of the stock to choose
        /// </summary>
        /// <param name="radioButtonDaily"></param>
        /// <param name="radioButtonWeekly"></param>
        /// <param name="radioButtonMonthly"></param>
        /// <returns></returns>
        public string GetTimeFrame(RadioButton radioButtonDaily, RadioButton radioButtonWeekly, RadioButton radioButtonMonthly)
        {
            //Looks at the radio buttons and returns the value of which one is checked by the user
            string timeframe = "";
            if (radioButtonDaily.Checked)
            {
                timeframe = "Day";
            }
            else if (radioButtonWeekly.Checked)
            {
                timeframe = "Week";
            }
            else if (radioButtonMonthly.Checked)
            {
                timeframe = "Month";
            }
            return timeframe;
        }
        /// <summary>
        /// If a radio button is changed to Day, then it adds only the ticker symbols with the Day timeframe to the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            if (GetTimeFrame(radioButtonDay, radioButtonWeekly, radioButtonMonthly) == "Day")
            {
                comboBoxTicker.Items.Clear();
                string[] files = Directory.GetFiles("Stock Data\\", "*Day*");
                comboBoxTicker.Items.AddRange(files);
            }
        }
        /// <summary>
        /// If a radio button is changed to Week, then it adds only the ticker symbols with the Week timeframe to the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (GetTimeFrame(radioButtonDay, radioButtonWeekly, radioButtonMonthly) == "Week")
            {
                comboBoxTicker.Items.Clear();
                string[] files = Directory.GetFiles("Stock Data\\", "*Week*");
                comboBoxTicker.Items.AddRange(files);
            }
        }
        /// <summary>
        /// If a radio button is changed to Month, then it adds only the ticker symbols with the Month timeframe to the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (GetTimeFrame(radioButtonDay, radioButtonWeekly, radioButtonMonthly) == "Month")
            {
                comboBoxTicker.Items.Clear();
                string[] files = Directory.GetFiles("Stock Data\\", "*Month*");
                comboBoxTicker.Items.AddRange(files);
            }
        }
    }
}
